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
    public class EventViewersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public EventViewersController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                var userInterests = await _context.PersonalEvent
                    .Where(pe => pe.UserId == user.Id)
                    .Select(pe => pe.EventId)
                    .ToListAsync();

                var events = await _context.Event
                    .Include(e => e.User)
                    .Where(e => !userInterests.Contains(e.Id))
                    .ToListAsync();

                var eventviewer = events.Select(e => new EventViewer
                {
                    Event = e,
                    User = e.User,
                }).ToList();

                ViewBag.Eventviewer = eventviewer;

                return View(eventviewer);
            }

            var allEvents = await _context.Event
                .Include(e => e.User)
                .ToListAsync();

            var allEventviewer = allEvents.Select(e => new EventViewer
            {
                Event = e,
                User = e.User,
            }).ToList();

            ViewBag.Eventviewer = allEventviewer;

            return View(allEventviewer);
        }




        public async Task<IActionResult> Interested(int eventId)
        {
            IdentityUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var existingInterest = await _context.PersonalEvent
                .FirstOrDefaultAsync(ui => ui.UserId == user.Id && ui.EventId == eventId);

            if (existingInterest == null)
            {
                var userInterest = new PersonalEvent
                {
                    UserId = user.Id,
                    EventId = eventId
                };

                _context.PersonalEvent.Add(userInterest);
                await _context.SaveChangesAsync();
            }

            //return RedirectToAction("Confirmation");
            return View("Confirmation");
        }

        // Akcja do usuwania zainteresowania użytkownika danym wydarzeniem
        //public async Task<IActionResult> NotInterested(int eventId)
        //{
        //    IdentityUser user = await _userManager.FindByNameAsync(User.Identity.Name);

        //    var existingInterest = await _context.PersonalEvent
        //        .FirstOrDefaultAsync(ui => ui.UserId == user.Id && ui.EventId == eventId);

        //    if (existingInterest != null)
        //    {
        //        _context.PersonalEvent.Remove(existingInterest);
        //        await _context.SaveChangesAsync();
        //    }

        //    return RedirectToAction("Index");
        //}
    }
}
