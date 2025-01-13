using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RGIS.Data;
using RGIS.Models;

namespace RGIS.Pages
{
    public class EventsModel : PageModel
    {
        private readonly AppDbContext _context;

        public EventsModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Event> Events { get; set; } = new List<Event>();
        public string SearchLocation { get; set; }

        public async Task OnGetAsync(string location)
        {
            SearchLocation = location;
            Events = string.IsNullOrWhiteSpace(location)
                ? await _context.Events.ToListAsync()
                : await _context.Events.Where(e => e.Location.Contains(location)).ToListAsync();
        }
    }
}
