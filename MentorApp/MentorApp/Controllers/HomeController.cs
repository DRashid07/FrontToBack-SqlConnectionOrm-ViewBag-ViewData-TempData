using MentorApp.Data;
using MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers
{
    public class HomeController(MentorAppDbContext context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var slider = default(MentorApp.Models.Slider);

            try
            {
                slider = await context.Sliders.AsNoTracking().FirstOrDefaultAsync();
            }
            catch
            {
                ViewBag.DbError = "Database connection is not available.";
            }

            HomeVm homeVm = new HomeVm
            {
                Slider = slider
            };
            return View(homeVm);
        }
    }
}
