using LogicBack.DAL;
using LogicBack.Extentions;
using LogicBack.Models;
using LogicBack.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicBack.Areas.LogisArea.Controllers
{
    [Area("LogisAdmin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ServiceController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Service> services = await _context.Services.ToListAsync();
            return View(services);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            if (!ModelState.IsValid) return View();
            if (service.Photo!=null)
            {
                if (service.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa olcusu 1mb dan kicik olan sekil secin");
                    return View();
                }
                service.Image = await service.Photo.FileCreate(_env.WebRootPath, @"assets\img");
                await _context.SaveChangesAsync();
                await _context.Services.AddAsync(service);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa sekil fayli secin");
                return View();
            }
        }
       public async Task<IActionResult> Detail(int id)
        {
            Service service = await _context.Services.FirstOrDefaultAsync(s => s.Id == id);
            if (service == null) return NotFound();
            return View(service);
        }
        public async Task<IActionResult> Delete(int id)
        {
            Service service = await _context.Services.FirstOrDefaultAsync(s => s.Id == id);
            {
                if (service == null) return NotFound();
                return View(service);
            }
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteService(int id)
        {
            Service service = await _context.Services.FirstOrDefaultAsync(s => s.Id == id);
            {
                if (service == null) return NotFound();
                _context.Services.Remove(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
