using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sillystringz.Models;
namespace Sillystringz.Controllers
{
    public class EngineersController : Controller
    {
        private readonly SillystringzContext _db;
        public EngineersController( SillystringzContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Engineer> model = _db.Engines.OrderBy(x => x.Name).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Engineer engineer)
        {
            _db.Engineers.Add(engineer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Engineer model = _db.Engineers.FirstOrDefault(e => e.EngineerId == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(x => x.EngineerId == id);
            return View(thisEngineer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(x => x.EngineerId == id);
            _db.Engineers.Remove(thisEngineer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {                    
            Course thisEngineer = _db.Engineers.FirstOrDefault(x => x.EngineerId == id);
            return View(thisEngineer);
        }
        [HttpPost]
        public ActionResult Edit(Engineer engineer)
        {
            _db.Entry(engineer).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddMachine(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(s => s.EngineerId == id);
            ViewBag.MachineId = new SelectList(_db.Machine, "MachineId", "Name");
            return View(thisEngineer);
        }
        [HttpPost]
        public ActionResult AddSpecialty(EngineerMachine engineerMachine)
        {
            if (engineerMachine.MachineId != 0)
            {
                if (_db.EngineerMachine.Where(x => x.EngineerId == engineerMachine.EngineerId && x.MachineId == engineerMachine.MachineId).ToHashSet().Count == 0)
                {
                _db.EngineerMachine.Add(engineerMachine);
                }
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}