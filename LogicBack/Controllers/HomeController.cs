using LogicBack.DAL;
using LogicBack.Models;
using LogicBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LogicBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.FirstOrDefaultAsync(),
                Icons = await _context.Icons.ToListAsync(),
                Abouts = await _context.Abouts.FirstOrDefaultAsync(),
                AboutLists = await _context.AboutLists.ToListAsync(),
                Services = await _context.Services.ToListAsync(),
                Actions = await _context.Actions.FirstOrDefaultAsync(),
                SocialMedias = await _context.SocialMedias.ToListAsync(),
                Settings = await _context.Settings.FirstOrDefaultAsync(),
            };
           return View(model);
        }
    }
}
