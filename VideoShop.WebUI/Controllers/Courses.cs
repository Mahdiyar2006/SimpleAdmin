using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using VideoShop.Core.Domains;
using VideoShop.Services.Services;
using static Utils;

namespace VideoShop.WebUI.Controllers
{
    [AdminAthentication]
    public class Courses : Controller
    {
        private readonly CourseService courseService
                                  = new CourseService();
        public IActionResult Index()
        {
            return View(courseService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOP(
            int ccId,
            int tId,
            string content,
            string cName,
            string cSubject
            )
        {
            courseService.Add(GetCourse(
                                   cName, cSubject, content, ccId, tId));

            return RedirectToAction(IndexName);
        }

        private string returnPath(int Id)
        {
            return ImageDirPath + Id + ImageExtention;
        }
        public IActionResult Delete(int Id)
        {
            courseService.Delete(Id);
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
            int ccId,
            int tId,
            string content,
            string cName,
            string cSubject
            )
        {
            courseService.Update(GetCourse(id,cName, cSubject, content, ccId, tId));

            return RedirectToAction(IndexName);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Id = id;

            return View();
        }

    }

}

