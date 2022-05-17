using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoShop.DataLayer;
using VideoShop.WebUI.Models;
using VideoShop.Services.Services;
using static Utils;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace VideoShop.WebUI.Controllers
{
    public class Home : Controller
    {
        private readonly AppUserService user = new AppUserService();
        private readonly ILogger<Home> _logger;
        private void ViewBagConfigurator(ActiveItem aI, ActivateSearch aS)
        {
            ViewBag.Active = aI;

            ViewBag.Search = aS;
        }
        public Home(ILogger<Home> logger)
        {
            _logger = logger;
        }
        [AdminAthentication]
        public IActionResult Index()
        {
            ViewBagConfigurator(ActiveItem.Dashboard, ActivateSearch.No);
            return View();
        }  

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string pass)
        {
            var userClaim = GetClaims(username);
            if (ModelState.IsValid)
            {
                if(CheckUserPassValidation(username, pass))
                {
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(userClaim), GetProperties());
                    return RedirectToAction(IndexName);

                }
            }
            return View();
        }
        private bool CheckUserPassValidation(string username, string password)
        {
            var items = user.GetAll();
            if (items.Where(i => i.UserName == username).Any() == true)
            {
                if(items.Where(i => i.Password == 
                EncryptionHelper.GetSha256Hash(password)).Any() == true)
                {
                    return true;
                }
            }
            return false;
        }

        private ClaimsIdentity GetClaims(string username)
        {
            return new ClaimsIdentity(new List<Claim>
            {
               
            }, CookieAuthenticationDefaults.AuthenticationScheme);
        }

        private int FindUserByUserName(string username)
        {
            var item = user.GetAll().Where(i => i.UserName == username).First();
            return item.Id;
        }

        private AuthenticationProperties GetProperties()
        {
            return new AuthenticationProperties
            {
                AllowRefresh = true,
                IsPersistent = true,
                ExpiresUtc = DateTime.UtcNow.AddDays(1),
            };
        }
        public async Task<IActionResult> SignOutAsync()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

    }
}
