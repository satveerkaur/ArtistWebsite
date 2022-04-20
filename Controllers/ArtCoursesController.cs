using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtistWebsite.Data;
using ArtistWebsite.Models;

namespace ArtistWebsite.Controllers
{
    public class ArtCoursesController : Controller
    {
        private readonly DataContext _context;

        public ArtCoursesController(DataContext context)
        {
            _context = context;
        }

        // GET: ArtCourses
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.artCourses.Include(a => a.Artists);
            return View(await dataContext.ToListAsync());
        }

        // GET: ArtCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artCourses = await _context.artCourses
                .Include(a => a.Artists)
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (artCourses == null)
            {
                return NotFound();
            }

            return View(artCourses);
        }

        // GET: ArtCourses/Create
        public IActionResult Create()
        {
            ViewData["ArtistID"] = new SelectList(_context.artists, "ArtistID", "City");
            return View();
        }

        // POST: ArtCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,CourseName,Duration,Price,ArtistID")] ArtCourses artCourses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artCourses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistID"] = new SelectList(_context.artists, "ArtistID", "City", artCourses.ArtistID);
            return View(artCourses);
        }

        // GET: ArtCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artCourses = await _context.artCourses.FindAsync(id);
            if (artCourses == null)
            {
                return NotFound();
            }
            ViewData["ArtistID"] = new SelectList(_context.artists, "ArtistID", "City", artCourses.ArtistID);
            return View(artCourses);
        }

        // POST: ArtCourses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CourseName,Duration,Price,ArtistID")] ArtCourses artCourses)
        {
            if (id != artCourses.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artCourses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtCoursesExists(artCourses.CourseID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistID"] = new SelectList(_context.artists, "ArtistID", "City", artCourses.ArtistID);
            return View(artCourses);
        }

        // GET: ArtCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artCourses = await _context.artCourses
                .Include(a => a.Artists)
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (artCourses == null)
            {
                return NotFound();
            }

            return View(artCourses);
        }

        // POST: ArtCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artCourses = await _context.artCourses.FindAsync(id);
            _context.artCourses.Remove(artCourses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtCoursesExists(int id)
        {
            return _context.artCourses.Any(e => e.CourseID == id);
        }
    }
}
