using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lessons_Learned_Database.Models
{
    public class Rating
    {

        [Required]
        [Range(1, 5)]
        public int RatingNumber { get; set; }

        [Key]
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }

        [Key]
        [ForeignKey("Lesson")]
        public int LessonId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public Lesson Lesson { get; set; }

    }
}
