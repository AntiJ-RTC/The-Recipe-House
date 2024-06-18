using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using System.Security.Claims;
using System.Xml.Linq;
using The_Recipe_House.Data;
using The_Recipe_House.Models;

namespace The_Recipe_House.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommentsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var applicationDbContext = _context.Comments.Where(c => c.ApplicationUserId == userId).Include(r => r.Recipe);

            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(t => t.ApplicationUser)
                .Include(t => t.Recipe)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }
        [Authorize]
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "UserName");
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Title");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Comment,Rating,RecipeId,ApplicationUserId")] Comments comments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comments);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Recipe");
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "UserName", comments.ApplicationUserId);
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Title", comments.RecipeId);
            return View(comments);
        }
        [Authorize]
        public async Task<IActionResult> Edit (int? id)
        {
            if (id == null)
            {
                return NotFound();  
            }
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "UserName", comment.ApplicationUserId);
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Title", comment.RecipeId);
            return View(comment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind("Id,Comment,Rating,RecipeId,ApplicationUserId")] Comments comments)
        {
            if(id != comments.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(comments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comments.Id))
                    {
                        return NotFound();
                    }
                    else { throw; }
                }
                return RedirectToAction("Index", "Recipe");
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "UserName", comments.ApplicationUserId);
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Title", comments.RecipeId);
            return View(comments);
        }
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var comment = await _context.Comments
                .Include(c => c.ApplicationUser)
                .Include(c => c.Recipe)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Recipe");
        }
        private bool CommentExists(int id)
        {
            return _context.Comments.Any(c => c.Id == id);
        }
    }
}
