using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MyCourse.Models.ViewModel
{
    public class CourseDetailViewModel : CourseViewModel
    {
        public string Description { get; set; }
        public List<LessonViewModel> Lessons { get; set; }

        public int TotalCourseDuration 
        { get => Lessons.Sum(i => i.Duration);
        }

        public static new CourseDetailViewModel FromDataRow(DataRow courseRow)
        {
            var courseDetailViewModel = new CourseDetailViewModel
            {
                Title = Convert.ToString(courseRow["Title"]),
                Description = Convert.ToString(courseRow["Description"]),
                ImagePath = "/Courses/" + Convert.ToString(courseRow["ImagePath"]),
                Author = Convert.ToString(courseRow["Author"]),
                Rating = Convert.ToDouble(courseRow["Rating"]),
                FullPrice = Convert.ToDecimal(courseRow["FullPrice"]),
                CurrentPrice = Convert.ToDecimal(courseRow["CurrentPrice"]),
                Id = Convert.ToInt32(courseRow["Id"]),
                Lessons = new List<LessonViewModel>()
            };
            return courseDetailViewModel;
        }

    }
}