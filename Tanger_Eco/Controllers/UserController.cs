using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Tanger_Eco.Data;
using TangerEco.Models;

namespace Tanger_Eco.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(ApplicationDbContext context,RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var Roles = (from c in _roleManager.Roles select c.Name).ToList();
            ViewBag.Roles = new SelectList(Roles);
            return View();
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View(new IdentityRole());
        }


        [HttpPost]
        public async Task<IActionResult> Create(PersonnelMinistreModel P_Mini)
        {
            if (ModelState.IsValid)
            {
                _context.Add(P_Mini);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(P_Mini);
        }
    }
}
