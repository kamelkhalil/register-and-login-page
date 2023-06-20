using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using register_and_login_page.Services;

namespace register_and_login_page.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserService _userService;

        [BindProperty]
        public User User { get; set; }

        public RegisterModel(UserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
            // Optional: Implement any necessary initialization logic
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _userService.Register(User);

            // Redirect to a success page or perform any other necessary actions
            return RedirectToPage("Login");
        }
    }
}
