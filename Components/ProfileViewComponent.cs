using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using The_Recipe_House.Data;

namespace The_Recipe_House.Components
{
    public class ProfileViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public ProfileViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var profile = await _context.Profiles.ToListAsync();
            return View(profile);
        }
    }
}
