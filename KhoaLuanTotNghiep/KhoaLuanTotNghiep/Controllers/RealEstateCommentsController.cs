using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KhoaLuanTotNghiep.Data;
using KhoaLuanTotNghiep_BackEnd.Models;
using KhoaLuanTotNghiep_BackEnd.ViewModels;

namespace KhoaLuanTotNghiep_BackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class RealEstateCommentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RealEstateCommentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Add(RealEstateCommentVM vm)
        {
            var comment = vm.Comment;
            var realEstateId = vm.RealEstateID;
            var rating = vm.Rating;

            RealEstateComment rComment = new RealEstateComment()
            {
                RealEstatesId = realEstateId,
                Comments = comment,
                Rating = rating,
                PublishedDate = DateTime.Now
            };

            _context.realEstateComments.Add(rComment);
            _context.SaveChanges();

            return RedirectToAction("Details", "RealEstate", new { id = realEstateId });   
        }

        // GET: RealEstateComments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.realEstateComments.Include(r => r.RealEstates);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RealEstateComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var realEstateComment = await _context.realEstateComments
                .Include(r => r.RealEstates)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (realEstateComment == null)
            {
                return NotFound();
            }

            return View(realEstateComment);
        }

        // GET: RealEstateComments/Create
        public IActionResult Create()
        {
            ViewData["RealEstatesId"] = new SelectList(_context.realEstates, "RealEstateID", "RealEstateID");
            return View();
        }

        // POST: RealEstateComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Comments,PublishedDate,RealEstatesId,Rating")] RealEstateComment realEstateComment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(realEstateComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RealEstatesId"] = new SelectList(_context.realEstates, "RealEstateID", "RealEstateID", realEstateComment.RealEstatesId);
            return View(realEstateComment);
        }

        // GET: RealEstateComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var realEstateComment = await _context.realEstateComments.FindAsync(id);
            if (realEstateComment == null)
            {
                return NotFound();
            }
            ViewData["RealEstatesId"] = new SelectList(_context.realEstates, "RealEstateID", "RealEstateID", realEstateComment.RealEstatesId);
            return View(realEstateComment);
        }

        // POST: RealEstateComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Comments,PublishedDate,RealEstatesId,Rating")] RealEstateComment realEstateComment)
        {
            if (id != realEstateComment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(realEstateComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RealEstateCommentExists(realEstateComment.Id))
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
            ViewData["RealEstatesId"] = new SelectList(_context.realEstates, "RealEstateID", "RealEstateID", realEstateComment.RealEstatesId);
            return View(realEstateComment);
        }

        // GET: RealEstateComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var realEstateComment = await _context.realEstateComments
                .Include(r => r.RealEstates)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (realEstateComment == null)
            {
                return NotFound();
            }

            return View(realEstateComment);
        }

        // POST: RealEstateComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var realEstateComment = await _context.realEstateComments.FindAsync(id);
            _context.realEstateComments.Remove(realEstateComment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RealEstateCommentExists(int id)
        {
            return _context.realEstateComments.Any(e => e.Id == id);
        }
    }
}
