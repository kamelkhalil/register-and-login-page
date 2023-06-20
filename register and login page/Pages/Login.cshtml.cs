using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using register_and_login_page.Services;

namespace register_and_login_page.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserService _userService;

        [BindProperty]
        public User User { get; set; }

        public LoginModel(UserService userService)
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

            bool isAuthenticated = _userService.Login(User.Username, User.Password);

            if (!isAuthenticated)
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password");
                return Page();
            }

            // Redirect to a success page or perform any other necessary actions
            return RedirectToPage("/Index");
        }
    }
}
