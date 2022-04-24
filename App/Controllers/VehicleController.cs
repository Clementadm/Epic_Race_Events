using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;
public class VehicleController: Controller
    {
        private readonly AppDbContext _dbContext;

        public VehicleController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult List()
        {
            var Vehicle = _dbContext.Vehicle.ToList();
            var VehicleListViewModel = new RaceListViewModel(
                Vehicle,
                "Liste de courses"
            );

            return View("RaceList", VehicleListViewModel);
        }

        // GET: Races/Details/5
        public ActionResult Details(int id, string toto)
        {

            return View();
        }

        // GET: Races/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View("CreateVehicle");
        }

        // POST: Races/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateVehicleRequest Vehicle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dbContext.Vehicle.Add(
                        new Vehicle()
                        {
                            VehiclesCategorie  = Vehicle.VehiclesCategorie ,
                            ConstructionDate  = Vehicle.VehicleConstructionDate ,
                            Brand  = Vehicle.VehicleBrand,
                            Model  = Vehicle.VehicleModel ,
                            HorsePower  = Vehicle.VehicleHorsePower ,
                            Pilote  = Vehicle.VehiclePilote ,
                            Picture  = Vehicle.VehiclePicture,

                        }
                    );
                    _dbContext.SaveChanges();
                    // TODO: vérifier une autre condition non gérée par les attributs
                    // De la logique de création => call BDD 

                    return RedirectToAction(nameof(List));
                }

                return View("CreateVehicle");
            }
            catch
            {
                return View("CreateVehicle");
            }
        }
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Races/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Races/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Races/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}