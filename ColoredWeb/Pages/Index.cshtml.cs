using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace ColoredWeb.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IConfiguration configuration)
        {
            Color = configuration["Color"] ?? Color;
        }

        public string Color { get; set; } = "Red";
    }
}