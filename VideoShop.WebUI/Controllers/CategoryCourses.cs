using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VideoShop.Core.Domains;
using VideoShop.Services.Services;
using static Utils;

namespace VideoShop.WebUI.Controllers
{
    [AdminAthentication]
    public class CategoryCourses : Controller
    {
        private readonly CategoryCourseService courseCategories 
                                          = new CategoryCourseService();

        public IActionResult Index()
        {
            return View(courseCategories.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOP(string title)
        {
            courseCategories.Add(GetCategoryCourse(title));

            return RedirectToAction(IndexName);
        }

        public IActionResult Delete(int Id)
        {
            courseCategories.Delete(Id);
            return RedirectToAction(IndexName);
        }

        public IActionResult Edit(int Id)
        {
            ViewBag.Id = Id;

            return View();
        }
        [HttpPost]
        public IActionResult EditOP(int id, string title)
        {
            courseCategories.Update(GetCategoryCourse(id, title));

            return RedirectToAction(IndexName);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
