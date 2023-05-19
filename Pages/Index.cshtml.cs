using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace poc_copilot.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    // implement a login form from the index page
    public async Task<IActionResult> OnPostAsync(string username, string password)
    {
        // check if the username and password are valid
        if (username == "admin" && password == "admin")
        {
            // create a new claim
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Administrator"),
            };

            // create a new ClaimsIdentity
            var claimsIdentity = new ClaimsIdentity(
                claims, Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme);

            // create a new ClaimsPrincipal
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            // sign-in the user
            await HttpContext.SignInAsync(
                Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme,
                claimsPrincipal);

            // redirect to the home page
            return RedirectToPage("/Index");
        }

        // return to the login page
        return Page();
    }

    // implement a logout form from the index page
    public async Task<IActionResult> OnPostLogoutAsync()
    {
        // sign-out the user
        await HttpContext.SignOutAsync(
            Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme);

        // redirect to the home page
        return RedirectToPage("/Index");
    }
}
