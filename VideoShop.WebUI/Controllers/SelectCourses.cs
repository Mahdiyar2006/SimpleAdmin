using Microsoft.AspNetCore.Mvc;
using VideoShop.Services.Services;
using static Utils;

namespace VideoShop.WebUI.Controllers
{
    [AdminAthentication]
    public class SelectCourses : Controller
    {
        private readonly SelectCourseService selectCourseService
                                          = new SelectCourseService();

        public IActionResult Index()
        {
            return View(selectCourseService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOP(int userId, int courseId)
        {
            selectCourseService.Add(GetSelectCourse(courseId ,userId));

            return RedirectToAction(IndexName);
        }

        public IActionResult Delete(int Id)
        {
            selectCourseService.Delete(Id);
            return RedirectToAction(IndexName);
        }

        public IActionResult Edit(int Id)
        {
            ViewBag.Id = Id;

            return View();
        }
        [HttpPost]
        public IActionResult EditOP(int id, int userId, int courseId)
        {
            selectCourseService.Update(GetSelectCourse(id, courseId, userId));

            return RedirectToAction(IndexName);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
