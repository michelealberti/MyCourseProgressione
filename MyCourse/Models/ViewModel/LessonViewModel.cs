using System;
using System.Data;

namespace MyCourse.Models.ViewModel
{
    public class LessonViewModel
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public int Duration { get; set; }

        public static LessonViewModel FromDataRow(DataRow courseRow)
        {
            var lessonViewModel = new LessonViewModel
            {
                Id = Convert.ToInt32(courseRow["ID"]),  
                Title = Convert.ToString(courseRow["Title"]),
                Description = Convert.ToString(courseRow["Description"]),
                Duration = Convert.ToInt32(courseRow["Duration"])
            };
            return lessonViewModel;
        }
    }
}