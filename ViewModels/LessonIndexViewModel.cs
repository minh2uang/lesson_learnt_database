using Lessons_Learned_Database.Models;
using System.Collections.Generic;

namespace Lessons_Learned_Database.ViewModels
{
    public class LessonIndexViewModel
    {
        public IEnumerable<Lesson> lessons { get; set; }
        public IEnumerable<Rating> ratings { get; set; }

    }
}
