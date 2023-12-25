using System;
using System.Data;
using System.Data.SqlTypes;

namespace MyCourse.Models.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath {  get; set; }
        public string Author { get; set; }
        public double Rating { get; set; }
        public decimal FullPrice{ get; set; }
        public decimal CurrentPrice { get; set; }

        public static CourseViewModel FromDataRow(DataRow courseRow)
        {
            var courseViewModel = new CourseViewModel
            {
                Title = Convert.ToString(courseRow["Title"]),
                ImagePath = "/Courses/" + Convert.ToString(courseRow["ImagePath"]),
                Author = Convert.ToString(courseRow["Author"]),
                Rating = Convert.ToDouble(courseRow["Rating"]),
                FullPrice = Convert.ToDecimal(courseRow["FullPrice"]),
                CurrentPrice = Convert.ToDecimal(courseRow["CurrentPrice"]),
                Id = Convert.ToInt32(courseRow["Id"])
            };
            return courseViewModel;
        }

     }
}
