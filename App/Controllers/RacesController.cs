using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Controllers
{
    public class RacesController : Controller
    {
        private readonly AppDbContext _dbContext;

        public RacesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

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
        public ActionResult Details(int id, Race raceDetails){
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
        // public async Task<IActionResult> Edit(int? id)
        // {
        //     if (id == null){
        //         return NotFound();
        //     }
        //     var raceFindId = await _dbContext.Races.FindAsync(id);
        //     if (raceFindId == null)
        //     {
        //         return NotFound();
        //     }
        //     return View("EditRace");
        // }

        // GET: Races/Edit/5
        public ActionResult Edit(int id){
            if (id == null){
                return NotFound();
            }
            var raceAtId =  _dbContext.Races.Find(id);
            if (raceAtId == null){
                return NotFound();
            }
            return View("EditRace");
        }

        // POST: Races/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id, Name, EventDate, Latitude, Longitude, MaxParticipant, RestrictedAge, Picture")] Race raceIdEdit){
            // if (ModelState.IsValid)
            // {
            //     _dbContext.Races.Update(raceIdEdit).State = EntityState.Modified;
            //     _dbContext.SaveChanges();
            // }
            // // return View(movie);
            // return RedirectToAction(nameof(List));

            Console.WriteLine("raceedit = ", raceIdEdit.Id);
            var race = new Race{
                Id = raceIdEdit.Id,
                Name = raceIdEdit.Name,
                EventDate = raceIdEdit.EventDate,
                Latitude = raceIdEdit.Latitude,
                Longitude = raceIdEdit.Longitude,
                MaxParticipant = raceIdEdit.MaxParticipant,
                Picture = raceIdEdit.Picture,
                RestrictedAge = raceIdEdit.RestrictedAge,
            };
            using (var db = _dbContext){
                var result = db.Races.SingleOrDefault(b => b.Id == raceIdEdit.Id);
                Console.WriteLine("azertyuiopoiuytrdxcvbnklmùmlkjtrdxcbn=)àézsrx n,lm*%M§l:kujyfdxwedfcv k;,ngcdfx pùmoijhytfesxbnnlij,gfcfhiokjgvtctyghgboikjfxwesdwx ik,nb ");
                Console.WriteLine("id = ", result.Id);
                if (result != null)
                {
                    try
                    {
                    db.Races.Attach(result);
                    result = race;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(List));
            }
    }







        }
        // public ActionResult Edit(Race raceIdEdit){
        //     var update = new Race {
        //         Id = raceIdEdit.Id,
        //         Name = raceIdEdit.Name,
        //         EventDate = raceIdEdit.EventDate,
        //         Latitude = raceIdEdit.Latitude,
        //         Longitude = raceIdEdit.Longitude,
        //         MaxParticipant = raceIdEdit.MaxParticipant,
        //         Picture = raceIdEdit.Picture,
        //         RestrictedAge = raceIdEdit.RestrictedAge,
        //     };
        //     raceIdEdit = update;
        //     _dbContext.Races.Update(raceIdEdit);
        //     // var Name = raceIdEdit.Name;
        //     // var EventDate = raceIdEdit.EventDate;
        //     // var Latitude = raceIdEdit.Latitude;
        //     // var Longitude = raceIdEdit.Longitude;
        //     // var MaxParticipant = raceIdEdit.MaxParticipant;
        //     // var Picture = raceIdEdit.Picture;
        //     // var RestrictedAge = raceIdEdit.RestrictedAge;
        //     return RedirectToAction(nameof(List));
        //     //return View("RaceList");
        // }
            // if (id != race.Id)
            // {
            //     return NotFound();
            // }

            // if (ModelState.IsValid)
            // {
            //     try
            //     // raceIdEdit = 
            //     {

                    // // TODO: Add update logic here
                    // _dbContext.Update(race);
                    // await _dbContext.SaveChangesAsync();
                    // // return RedirectToAction(nameof(Index));
        //         }
        //         catch
        //         {
        //             if (!id.Equals(race.Id))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View("RaceEdit");
        // }
//------------------------------------------
        // // GET: Races/Delete/5
        // public ActionResult Delete(int? id){
        //     if (id == null){
        //         return NotFound();
        //     }

        //     var race = await _dbContext.Races
        //         .FirstOrDefaultAsync(m => m.Id == id);
        //     if (race == null)
        //     {
        //         return NotFound();
        //     }

        //     return View("DeleteRace");
        // }

        // // POST: Races/Delete/5
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> DeleteConfirmed(int id){
        //     var race = await _dbContext.Races.FindAsync(id);
        //     _dbContext.Races.Remove(race);
        //     await _dbContext.SaveChangesAsync();
        //     return RedirectToAction(nameof(Index));
        // }
}
