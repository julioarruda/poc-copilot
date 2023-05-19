using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace poc_copilot.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public UpdateResult UpdateResult { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Username == "admin" && Password == "admin")
            {
                UpdateResult = new UpdateResult
                {
                    Type = "success",
                    Message = "Login successful!"
                };
            }
            else
            {
                UpdateResult = new UpdateResult
                {
                    Type = "danger",
                    Message = "Invalid credentials!"
                };
            }
        }
    }

    public class UpdateResult
    {
        public string Type { get; set; }
        public string Message { get; set; }
    }
}