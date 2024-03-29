using api.DTOs;
using front.Constant;
using front.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace front.Pages.Quizz;
public class Index : PageModel
{
    public List<QuizzDTO> quiz { get; set; } = new List<QuizzDTO>();
    private readonly ILogger<Quiz> _logger;

    public Index(ILogger<Quiz> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> OnGet()
    {
        if (Request.Cookies["email"] == null)
        {
            return RedirectToPage("/Login/Index");
        }
        var http = new HttpClient();
        var request = await http.GetAsync(Api.QUIZ_URL);
        quiz = await Json.SerializeAsync<List<QuizzDTO>>(request);
        Console.WriteLine(quiz.ToString());
        return Page();
    }
}
