using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lessons_Learned_Database.Data;
using Lessons_Learned_Database.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Lessons_Learned_Database.Controllers
{
    [Authorize]
    public class RatingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public RatingsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            
        }

        // GET: Ratings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Rating.Include(r => r.IdentityUser).Include(r => r.Lesson);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Ratings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating
                .Include(r => r.IdentityUser)
                .Include(r => r.Lesson)
                .FirstOrDefaultAsync(m => m.LessonId == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // GET: Ratings/Create
        [Authorize]
        public IActionResult Create(int id)
        {
            var rating = from m in _context.Rating select m;
            ViewData["LessonId"] = id;
            var r = rating.Where(m => m.LessonId == id && m.IdentityUserId == _userManager.GetUserId(User)).FirstOrDefault();
           
               if ( r != null)
                    return RedirectToAction(actionName: "Edit", controllerName: "Ratings",
                        new { id = id, id2 = _userManager.GetUserId(User) });
        
            return View();

        }

        // POST: Ratings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("RatingNumber,IdentityUserId,LessonId")] Rating rating)
        {


            
            if (ModelState.IsValid)
            {
                var exist = _context.Rating.Any(c => c.LessonId == rating.LessonId && c.IdentityUserId == rating.IdentityUserId);   
                if (exist)
                {
                   // _context.Entry(r).State = EntityState.Detached;
                    _context.Update(rating);
                 
                }
                else
                    _context.Add(rating);
                await _context.SaveChangesAsync();


                var lessonRate = _context.Rating.Where(c => c.LessonId == rating.LessonId);
                decimal count = 0;
                decimal sum = 0;
                foreach (var l in lessonRate)
                {
                    sum = sum + l.RatingNumber;
                    count++;
                }
                sum = sum / count;
                var lesson = _context.Lesson.FirstOrDefault(s => s.LessonId == rating.LessonId);
                lesson.Rating = sum;
                _context.Update(lesson);
                _context.SaveChanges();
                return RedirectToAction(controllerName: "Lessons", actionName: "Index");
            }

            return RedirectToAction(controllerName: "Lessons", actionName: "Index");
        }
        [HttpPost]
        public IActionResult test(string lessonId)
        {
            return RedirectToAction(actionName: "Index");
        }
        // GET: Ratings/Edit/5
        public async Task<IActionResult> Edit(int? id, string id2)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating.FindAsync(id,id2);
            if (rating == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", rating.IdentityUserId);
            ViewData["LessonId"] = new SelectList(_context.Lesson, "LessonId", "ProjectName", rating.LessonId);
            return View(rating);
        }

        // POST: Ratings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RatingNumber,IdentityUserId,LessonId")] Rating rating)
        {
            if (id != rating.LessonId)
            {
                return NotFound();
            }
           
            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(rating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RatingExists(rating.LessonId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var lessonRate = _context.Rating.Where(c => c.LessonId == rating.LessonId);
                decimal count = 0;
                decimal sum = 0;
                foreach (var l in lessonRate)
                {
                    sum = sum + l.RatingNumber;
                    count++;
                }
                sum = sum / count;

                var lesson = _context.Lesson.FirstOrDefault(s => s.LessonId == rating.LessonId);
                lesson.Rating = sum;
                _context.Update(lesson);
                _context.SaveChanges();
                return RedirectToAction(controllerName: "Lessons", actionName: "Index");
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", rating.IdentityUserId);
            ViewData["LessonId"] = new SelectList(_context.Lesson, "LessonId", "ProjectName", rating.LessonId);
            return RedirectToAction(controllerName: "Lessons", actionName: "Index");
        }

        // GET: Ratings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating
                .Include(r => r.IdentityUser)
                .Include(r => r.Lesson)
                .FirstOrDefaultAsync(m => m.LessonId == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // POST: Ratings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rating = await _context.Rating.FindAsync(id);
            _context.Rating.Remove(rating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RatingExists(int id)
        {
            return _context.Rating.Any(e => e.LessonId == id);
        }
    }
}
