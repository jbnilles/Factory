using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sillystringz.Models;
namespace Sillystringz.Controllers
{
    public class MachinesController : Controller
    {
        private readonly SillystringzContext _db;
        public MachinesController( SillystringzContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Machine> model = _db.Machine.OrderBy(x => x.Name).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Machine machine)
        {
            _db.Machine.Add(machine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Machine model = _db.Machine.FirstOrDefault(e => e.MachineId == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            Machine thisMachine = _db.Machine.FirstOrDefault(x => x.MachineId == id);
            return View(thisMachine);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Machine thisMachine = _db.Machine.FirstOrDefault(x => x.MachineId == id);
            _db.Machine.Remove(thisMachine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {                    
            Machine thisMachine = _db.Machine.FirstOrDefault(x => x.MachineId == id);
            return View(thisMachine);
        }
        [HttpPost]
        public ActionResult Edit(Machine machine)
        {
            _db.Entry(machine).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddEngineer(int id)
        {
            Machine thisMachine = _db.Machine.FirstOrDefault(s => s.MachineId == id);
            ViewBag.EngineerId = new SelectList(_db.Engineers, "MachineId", "Name");
            return View(thisMachine);
        }
        [HttpPost]
        public ActionResult AddSpecialty(EngineerMachine engineerMachine)
        {
            if (engineerMachine.EngineerId != 0)
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