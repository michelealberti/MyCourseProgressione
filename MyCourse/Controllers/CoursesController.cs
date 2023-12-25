using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModel;
using System.Collections.Generic;

namespace MyCourse.Controllers
{
       public class CoursesController : Controller
        {

        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService; 
        }
        public IActionResult Index()
        {
            List<CourseViewModel> courses = courseService.GetCourses();
            return View(courses);
        }

        public IActionResult Detail(int id) 
        {
            CourseDetailViewModel viewModel = courseService.GetCourse(id);
            return View(viewModel) ;
        }
    }
}
