using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Authorize]
    public class RacesController : Controller
    {
        private readonly AppDbContext _dbContext;

        public RacesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Races
        public ActionResult List()
        {
            var races = _dbContext.Races.ToList();
            var raceListViewModel = new RaceListViewModel(
                races,
                "Liste de courses"
            );

            return View("RaceList", raceListViewModel);
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
            return View("CreateRace");
        }

        // POST: Races/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRaceRequest race)
        {
            try
            {
                if (race.RaceEventDate.DayOfWeek == DayOfWeek.Tuesday) 
                {
                    ModelState.AddModelError(String.Empty, "No race allowed on Tuesdays !");
                }

                if (ModelState.IsValid)
                {
                    _dbContext.Races.Add(
                        new Race()
                        {
                            Name = race.RaceName,
                            EventDate = race.RaceEventDate,
                            // EventBeginning = race.EventBeginning,
                            Latitude = race.Latitude,
                            Longitude = race.Longitude,
                            MaxParticipant = race.MaxParticipant,
                            Picture = race.Picture,
                            RestrictedAge = race.RestrictedAge,
                            // Result = race.Result
                        }
                    );
                    _dbContext.SaveChanges();
                    // TODO: vérifier une autre condition non gérée par les attributs
                    // De la logique de création => call BDD 

                    return RedirectToAction(nameof(List));
                }

                return View("CreateRace");

            }
            catch
            {
                return View("CreateRace");
            }
        }

        // GET: Races/Edit/5
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