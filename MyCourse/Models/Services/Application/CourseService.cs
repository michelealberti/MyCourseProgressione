using MyCourse.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace MyCourse.Models.Services.Application
{
    public class CourseService : ICourseService
    {
        public List<CourseViewModel> GetCourses()
        {
            var courseList = new List<CourseViewModel>();
            var rand = new Random();
            for (int i = 1; i <= 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel()
                {
                    Id = i,
                    Title = $"Corso {i}",
                    CurrentPrice = price,
                    FullPrice = rand.NextDouble() > 0.5 ? price : price - 1,
                    Author = "Nome cognome",
                    Rating = rand.NextDouble() * 5.0,
                    ImagePath = "/images/Logo.png"
                };
                courseList.Add(course);
            }
            return courseList;
        }

        public CourseDetailViewModel GetCourse(int id)
        {
            var rand = new Random();
            var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
            var course = new CourseDetailViewModel
            {
                Id = id,
                Title = $"Corso {id}",
                CurrentPrice = price,
                FullPrice = rand.NextDouble() > 0.5 ? price : price - 1,
                Author = "Nome cognome",
                Rating = rand.NextDouble() * 5.0,
                ImagePath = "/images/Logo.png",
                Description = $"Descrizione {id}",
                Lessons = new List<LessonViewModel>()
            };

            for (int i = 1; i <= 5; i++)
            {
                var lesson = new LessonViewModel()
                {
                    Title = $"Lezione {i}",
                    Duration = TimeSpan.FromSeconds(rand.Next(40, 90))
                };
                course.Lessons.Add(lesson);
            }
            return course;
        }
    }
}
