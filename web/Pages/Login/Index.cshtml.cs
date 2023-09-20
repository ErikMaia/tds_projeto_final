using System;
using System.Net.Http; // Importe o namespace necessário
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using api.DTOs;

namespace front.Pages.Login
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;

        public Index(ILogger<Index> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var http = new HttpClient();
            var student = new StudentDTO()
            {
                Email = Request.Form["email"],
                Password = Request.Form["password"],
            };

            var response = await http.PostAsJsonAsync(Api.STUDENT + "/login", student);
            if (response.IsSuccessStatusCode)
            {
                var cookieOptions = new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddDays(1),
                    Domain = HttpContext.Request.Host.Host,
                    Path = "/"
                };

                Response.Cookies.Append("session-id", "12345", cookieOptions);

                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}

