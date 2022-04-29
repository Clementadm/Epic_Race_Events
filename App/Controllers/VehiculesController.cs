#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Data;
using App.Models;
using Microsoft.AspNetCore.Authorization;

namespace App.Controllers
{
    [Authorize]
    public class VehiculesController : Controller
    {
        private readonly AppDbContext _context;

        public VehiculesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Vehicules
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vehicules.ToListAsync());
        }

        // GET: Vehicules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicule = await _context.Vehicules
                .FirstOrDefaultAsync(m => m.ID == id);

            if (vehicule == null)
            {
                return NotFound();
            }

            return View(vehicule);
        }

        // GET: Vehicules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vehicules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,niveauDePuissance,anneeDeContruction")] Vehicule vehicule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicule);
        }

        // GET: Vehicules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicule = await _context.Vehicules.FindAsync(id);

            if (vehicule == null)
            {
                return NotFound();
            }
            return View(vehicule);
        }

        // POST: Vehicules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,niveauDePuissance,anneeDeContruction")] Vehicule vehicule)
        {
            if (id != vehicule.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehiculeExists(vehicule.ID))
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
            return View(vehicule);
        }

        // GET: Vehicules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicule = await _context.Vehicules
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vehicule == null)
            {
                return NotFound();
            }

            return View(vehicule);
        }

        // POST: Vehicules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicule = await _context.Vehicules.FindAsync(id);
            _context.Vehicules.Remove(vehicule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehiculeExists(int id)
        {
            return _context.Vehicules.Any(e => e.ID == id);
        }
    }
}// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using App.Data;
// using App.Models;
// using App.ViewModels;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;

// namespace App.Controllers
// {
// public class VehicleController: Controller
//     {
//         private readonly AppDbContext _dbContext;

//         public VehicleController(AppDbContext dbContext)
//         {
//             _dbContext = dbContext;
//         }

//         public ActionResult List()
//         {
//             var Vehicle = _dbContext.Vehicules.ToList();
//             var VehicleListViewModel = new VehiculesListViewModel(
//                 Vehicle,
//                 "Liste de véhicule"
//             );

//             return View("VehiculeList", VehicleListViewModel);
//         }

//         // GET: Races/Details/5
//         public ActionResult Details(int id, string toto)
//         {

//             return View();
//         }

//         // GET: Races/Create
//         [HttpGet]
//         public ActionResult Create()
//         {
//             return View("CreateVehicle");
//         }

//         // POST: Races/Create
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public ActionResult Create(CreateVehicleRequest Vehicule)
//         {
//             try
//             {
//                 if (ModelState.IsValid)
//                 {
//                     _dbContext.Vehicules.Add(
//                         new Vehicule()
//                         {
//                             id  = Vehicule.id ,
//                             name  = Vehicule.name ,
//                             categories = Vehicule.categories,
//                             niveauDePuissance = Vehicule.niveauDePuissance,
//                             anneeDeContruction = Vehicule.anneeDeContruction,
//                         }
//                     );
//                     _dbContext.SaveChanges();
//                     // TODO: vérifier une autre condition non gérée par les attributs
//                     // De la logique de création => call BDD 

//                     return RedirectToAction(nameof(List));
//                 }

//                 return View("CreateVehicle");
//             }
//             catch
//             {
//                 return View("CreateVehicle");
//             }
//         }
//         public ActionResult Edit(int id)
//         {
//             return View();
//         }

//         // POST: Races/Edit/5
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public ActionResult Edit(int id, IFormCollection collection)
//         {
//             try
//             {
//                 // TODO: Add update logic here

//                 return RedirectToAction(nameof(Index));
//             }
//             catch
//             {
//                 return View();
//             }
//         }

//         // GET: Races/Delete/5
//         public ActionResult Delete(int id)
//         {
//             return View();
//         }

//         // POST: Races/Delete/5
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public ActionResult Delete(int id, IFormCollection collection)
//         {
//             try
//             {
//                 // TODO: Add delete logic here

//                 return RedirectToAction(nameof(Index));
//             }
//             catch
//             {
//                 return View();
//             }
//         }
//     }
// }