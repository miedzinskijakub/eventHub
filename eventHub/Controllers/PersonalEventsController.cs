using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eventHub.Data;
using eventHub.Models;

namespace eventHub.Controllers
{
    [Authorize]
    public class PersonalEventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public PersonalEventsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            IdentityUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var personalEvents = await _context.PersonalEvent
                .Include(pe => pe.Event)
                .Where(pe => pe.UserId == user.Id)
                .ToListAsync();

            return View(personalEvents);
        }

        public async Task<IActionResult> UnmarkInterest(int eventId)
        {
            IdentityUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var existingInterest = await _context.PersonalEvent
                .FirstOrDefaultAsync(pe => pe.UserId == user.Id && pe.EventId == eventId);

            if (existingInterest != null)
            {
                _context.PersonalEvent.Remove(existingInterest);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        
    }
}
