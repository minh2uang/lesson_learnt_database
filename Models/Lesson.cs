using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lessons_Learned_Database.Models
{
    public class Lesson
    {
        [Required]
        public int LessonId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Project")]

        public string ProjectName { get; set; }

        [Display(Name = "Lesson Title")]
        public string LessonTitle { get; set; }

        [Required]
        [StringLength(200)]
        public string Abstract { get; set; }

        [Display(Name = "Organization")]
        [StringLength(50)]
        public string Organization { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime DateStart { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime DateEnd { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Budget")]
        public decimal Budget { get; set; }

        [Range(minimum: 0, maximum: 1000000000000)]
        [Display(Name = "People_Invole")]
        public int Size { get; set; }


        [Display(Name = "Objective Achievement")]
        public string ObjectiveAchievement { get; set; }

        [Display(Name = "Lessons Learned")]
        [StringLength(1000)]
        public string LessonsLearned { get; set; }

        public string Risk { get; set; }

        public string Stakeholder { get; set; }

        public string Technology { get; set; }

        public IdentityUser User { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public decimal Rating { get; set; }
    }
}
