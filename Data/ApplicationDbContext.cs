using Lessons_Learned_Database.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lessons_Learned_Database.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Lessons_Learned_Database.Models.Lesson> Lesson { get; set; }
        public DbSet<Lessons_Learned_Database.Models.Rating> Rating { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Rating>().HasKey(c => new { c.LessonId, c.IdentityUserId });
        }

    }
}
