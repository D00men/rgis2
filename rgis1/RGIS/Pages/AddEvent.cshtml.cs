using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RGIS.Data;
using RGIS.Models; 
using System;
using System.Threading.Tasks;

namespace RGIS.Pages
{
    public class AddEventModel : PageModel
    {
        private readonly AppDbContext _context;

        public AddEventModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event NewEvent { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(NewEvent); 
                await _context.SaveChangesAsync(); 
                return RedirectToPage("/Index"); 
            }
            return Page();
        }
    }
}
