using Microsoft.AspNetCore.Mvc;
using VideoShop.Services.Services;
using VideoShop.Core.Domains;
using System.Linq;
using static Utils;

namespace VideoShop.WebUI.Controllers
{
    [AdminAthentication]
    public class Teachers : Controller
    {
        private readonly TeacherService teacherService = new TeacherService();
        public IActionResult Index()
        {
            return View(teacherService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOP(
            string name,
            int age,
            string address
            )
        {
            teacherService.Add(GetTeacher(name, age, address));

            return RedirectToAction(IndexName);
        }

        public IActionResult Delete(int Id)
        {
            teacherService.Delete(Id);

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
            int age,
            string address)
        {
            teacherService.Update(GetTeacher(id, name, age, address));

            return RedirectToAction(IndexName);
        }
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;

            return View();
        }


    }
}
