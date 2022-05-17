using Microsoft.AspNetCore.Mvc;
using VideoShop.Services.Services;
using VideoShop.Core.Domains;
using System.Linq;
using static Utils;

namespace VideoShop.WebUI.Controllers
{
    [AdminAthentication]
    public class Users : Controller
    {
        private readonly AppUserService appUserService = new AppUserService();
        public IActionResult Index()
        {
            return View(appUserService.GetAll());
        }
        public IActionResult Create()
        {
           return View();
        }
        [HttpPost]
        public IActionResult CreateOP(
            string name, 
            string lastname,
            string username,
            string password)
        {
            appUserService.Add(GetUser(username, name, lastname, password));

            return RedirectToAction(IndexName);
        }

        public IActionResult Delete(int Id)
        {
            appUserService.Delete(Id);

            return RedirectToAction(IndexName);
        }

        public IActionResult Edit(int Id)
        {
            ViewBag.Id = Id;

            return View();
        }
        [HttpPost]
        public IActionResult EditOP(
            int id,
            string name,
            string lastname,
            string username,
            string password)
        { 
            appUserService.Update(GetUser(
                id, username, name, lastname, password));

            return RedirectToAction(IndexName);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
