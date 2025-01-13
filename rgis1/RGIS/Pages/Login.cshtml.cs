using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RGIS.Data;
using RGIS.Models;

namespace RGIS.Pages
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;

        public string ErrorMessage { get; set; }

        public LoginModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ErrorMessage = "Email and password are required.";
                return Page();
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                ErrorMessage = "Invalid email or password.";
                return Page();
            }



            return RedirectToPage("Index");
        }
    }
}
