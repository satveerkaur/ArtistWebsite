using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtistWebsite.Data;
using ArtistWebsite.Models;
using Microsoft.AspNetCore.Authorization;

namespace ArtistWebsite.Controllers
{
    public class ArtCollectionsController : Controller
    {
        private readonly DataContext _context;

        public ArtCollectionsController(DataContext context)
        {
            _context = context;
        }

        // GET: ArtCollections
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.artCollection.Include(a => a.Artists);
            return View(await dataContext.ToListAsync());
        }

        // GET: ArtCollections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artCollection = await _context.artCollection
                .Include(a => a.Artists)
                .FirstOrDefaultAsync(m => m.ArtID == id);
            if (artCollection == null)
            {
                return NotFound();
            }

            return View(artCollection);
        }

        [Authorize(Roles = "Admin,Artist")]
        // GET: ArtCollections/Create
        public IActionResult Create()
        {
            ViewData["ArtistID"] = new SelectList(_context.artists, "ArtistID", "ArtistID");
            return View();
        }

        // POST: ArtCollections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtID,Name,Year,ArtPrice,ArtistID")] ArtCollection artCollection)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artCollection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistID"] = new SelectList(_context.artists, "ArtistID", "ArtistID", artCollection.ArtistID);
            return View(artCollection);
        }

        // GET: ArtCollections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artCollection = await _context.artCollection.FindAsync(id);
            if (artCollection == null)
            {
                return NotFound();
            }
            ViewData["ArtistID"] = new SelectList(_context.artists, "ArtistID", "ArtistID", artCollection.ArtistID);
            return View(artCollection);
        }

        // POST: ArtCollections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtID,Name,Year,ArtPrice,ArtistID")] ArtCollection artCollection)
        {
            if (id != artCollection.ArtID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artCollection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtCollectionExists(artCollection.ArtID))
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
            ViewData["ArtistID"] = new SelectList(_context.artists, "ArtistID", "ArtistID", artCollection.ArtistID);
            return View(artCollection);
        }

        // GET: ArtCollections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artCollection = await _context.artCollection
                .Include(a => a.Artists)
                .FirstOrDefaultAsync(m => m.ArtID == id);
            if (artCollection == null)
            {
                return NotFound();
            }

            return View(artCollection);
        }

        // POST: ArtCollections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artCollection = await _context.artCollection.FindAsync(id);
            _context.artCollection.Remove(artCollection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtCollectionExists(int id)
        {
            return _context.artCollection.Any(e => e.ArtID == id);
        }
    }
}
