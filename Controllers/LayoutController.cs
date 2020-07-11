using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lessons_Learned_Database.Data;
using Lessons_Learned_Database.ViewModels;
namespace Lessons_Learned_Database.Controllers
{
    public class LayoutController : Controller
    {

        public IActionResult Articles()
        {
            return View();
        }


        private readonly ApplicationDbContext _context;

        public LayoutController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Search(string id, string projectName, string risk, string stakeholder, string technology, decimal? budgetFrom, decimal? budgetTo)
        {
            
            var lessons = from m in _context.Lesson select m;
            if (!String.IsNullOrEmpty(id)) {
                lessons = lessons.Where(s => s.ProjectName.Contains(id) || 
                                        s.Risk.Contains(id) ||
                                        s.Stakeholder.Contains(id)||
                                        s.Technology.Contains(id) ||
                                        s.LessonTitle.Contains(id)
                                        );                  
            }
            if (!String.IsNullOrEmpty(risk)) {
                lessons = lessons.Where(s => s.Risk.Contains(risk));
            }
            if (!String.IsNullOrEmpty(stakeholder)) {
                lessons = lessons.Where(s => s.Stakeholder.Contains(stakeholder));
            }
            if (!String.IsNullOrEmpty(projectName)) { 
            
                lessons = lessons.Where(s => s.ProjectName.Contains(projectName));
            }
            if (!String.IsNullOrEmpty(technology)) {
                lessons = lessons.Where(s => s.Technology.Contains(technology));
            }
            if (budgetFrom.HasValue) {
                lessons = lessons.Where(s =>  s.Budget >= budgetFrom); ;
            }
            if (budgetTo.HasValue) {
                lessons = lessons.Where(s => s.Budget <= budgetTo); ;
            }
            LessonIndexViewModel vm = new LessonIndexViewModel
            {
                lessons = lessons,
                ratings = _context.Rating.ToList()
            };
            return View("~/Views/Lessons/Index.cshtml",vm);
        }
    }
}