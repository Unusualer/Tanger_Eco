using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TangerEco.Models;
using Tanger_Eco.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Tanger_Eco.Models;

namespace Tanger_Eco.Controllers
{
      public class DemandeModelsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public DemandeModelsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [Authorize]
        // GET: DemandeModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DemandeModel.Include(d => d.DataCollector).Include(d => d.PersonnelMinistre).Include(d => d.PersonnelUniversite);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DemandeModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DemandeModel == null)
            {
                return NotFound();
            }

            var demandeModel = await _context.DemandeModel
                .Include(d => d.DataCollector)
                .Include(d => d.PersonnelMinistre)
                .Include(d => d.PersonnelUniversite)
                .FirstOrDefaultAsync(m => m.DemandeModelId == id);
            if (demandeModel == null)
            {
                return NotFound();
            }

            return View(demandeModel);
        }

        [Authorize(Roles="DataCollector")]
        // GET: DemandeModels/Create
        public IActionResult Create()
        {

            ViewBag.PersonnelMinistreId = new SelectList(_context.Set<PersonnelMinistreModel>(), "Id", "Name");
            ViewBag.PersonnelUniversiteId = new SelectList(_context.Set<PersonnelUniversiteModel>(), "Id", "Name");


            return View();
        }
        
        // POST: DemandeModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DemandeModelId,Title,Description,DateCreation,Statut,DataCollectorModelId,PersonnelMinistreModelId,PersonnelUniversiteModelId")] DemandeModel demandeModel)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                demandeModel.DataCollectorModelId = currentUser.Id;
                demandeModel.DataCollector = currentUser;
            }
            if (ModelState.IsValid)
            {
                if (Request.Form["SelectedPersonnelType"].Equals("Ministre"))
                {
                    demandeModel.PersonnelMinistreId = Request.Form["PersonnelMinistreId"];
                }
                else if (Request.Form["SelectedPersonnelType"].Equals("Universite"))
                {
                    demandeModel.PersonnelUniversiteId = Request.Form["PersonnelUniversiteId"];
                }
                
               

                _context.Add(demandeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.PersonnelMinistreId = new SelectList(_context.Set<PersonnelMinistreModel>(), "Id", "Name",demandeModel.PersonnelMinistreId);
            ViewBag.PersonnelUniversiteId = new SelectList(_context.Set<PersonnelUniversiteModel>(), "Id", "Name", demandeModel.PersonnelUniversiteId);
            return View(demandeModel);
        }
        [Authorize]
        // GET: DemandeModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DemandeModel == null)
            {
                return NotFound();
            }

            var demandeModel = await _context.DemandeModel.FindAsync(id);
            if (demandeModel == null)
            {
                return NotFound();
            }

            var currentStatut = demandeModel.Statut.ToString();
            ViewBag.CurrentStatut = currentStatut;

            // Récupérer la liste des statuts disponibles
            var statuts = Enum.GetValues(typeof(DemandeModel.StatutDemande))
                              .Cast<DemandeModel.StatutDemande>()
                              .Select(s => new SelectListItem
                              {
                                  Value = s.ToString(),
                                  Text = s.ToString()
                              });

            // Créer un SelectList avec la liste des statuts et la valeur actuelle de la demande
            var selectList = new SelectList(statuts, "Value", "Text", demandeModel.Statut);

            // Attribuer le SelectList à une propriété de modèle
            ViewData["Statuts"] = selectList;


            ViewBag.PersonnelMinistreId = new SelectList(_context.Set<PersonnelMinistreModel>(), "Id", "Name", demandeModel.PersonnelMinistreId);
            ViewBag.PersonnelUniversiteId = new SelectList(_context.Set<PersonnelUniversiteModel>(), "Id", "Name", demandeModel.PersonnelUniversiteId);

            return View(demandeModel);
        }

        // POST: DemandeModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DemandeModelId,Title,Description,DateCreation,Statut,DataCollectorModelId,PersonnelMinistreModelId,PersonnelUniversiteModelId")] DemandeModel demandeModel)
        {
            if (id != demandeModel.DemandeModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (User.IsInRole("DataCollector"))
                    {
                        if (Request.Form["SelectedPersonnelType"].Equals("Ministre"))
                        {
                            demandeModel.PersonnelMinistreId = Request.Form["PersonnelMinistreId"];
                        }
                        else if (Request.Form["SelectedPersonnelType"].Equals("Universite"))
                        {
                            demandeModel.PersonnelUniversiteId = Request.Form["PersonnelUniversiteId"];
                        }
                        _context.Update(demandeModel);
                    }
                    else
                    {
                        var existingDemandeModel = await _context.DemandeModel.FindAsync(id);
                        demandeModel.DataCollectorModelId = existingDemandeModel.DataCollectorModelId;
                        demandeModel.PersonnelMinistreId = existingDemandeModel.PersonnelMinistreId;
                        demandeModel.PersonnelUniversiteId = existingDemandeModel.PersonnelUniversiteId;
                        existingDemandeModel.Statut = demandeModel.Statut;
                    }

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DemandeModelExists(demandeModel.DemandeModelId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(demandeModel);
        }

        [Authorize(Roles ="DataCollector")]
        // GET: DemandeModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DemandeModel == null)
            {
                return NotFound();
            }

            var demandeModel = await _context.DemandeModel
                .Include(d => d.DataCollector)
                .Include(d => d.PersonnelMinistre)
                .Include(d => d.PersonnelUniversite)
                .FirstOrDefaultAsync(m => m.DemandeModelId == id);
            if (demandeModel == null)
            {
                return NotFound();
            }

            return View(demandeModel);
        }
        
        // POST: DemandeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DemandeModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DemandeModel'  is null.");
            }
            var demandeModel = await _context.DemandeModel.FindAsync(id);
            if (demandeModel != null)
            {
                _context.DemandeModel.Remove(demandeModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DemandeModelExists(int id)
        {
          return (_context.DemandeModel?.Any(e => e.DemandeModelId == id)).GetValueOrDefault();
        }
    }
}
