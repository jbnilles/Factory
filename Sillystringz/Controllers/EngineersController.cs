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
        var thisEngineer = _db.Engineers.FirstOrDefault(x => x.EngineerId == id);
        return View(thisEngineer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
        var thisEngineer = _db.Engineers.FirstOrDefault(x => x.EngineerId == id);
        _db.Engineers.Remove(thisEngineer);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {                    
            Course thisEngineer = _db.Engineer.FirstOrDefault(x => x.EngineerId == id);
            return View(thisCourse);
        }
        [HttpPost]
        public ActionResult Edit(Engineer engineer)
        {
            _db.Entry(engineer).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}