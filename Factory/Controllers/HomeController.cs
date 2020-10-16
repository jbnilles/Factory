using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
namespace Factory.Controllers
{
    public class HomeController : Controller
    {
        private readonly FactoryContext _db;
        public HomeController(FactoryContext db)
        {
            _db = db;
        }
        [HttpGet("/")]
        public ActionResult Index()
        { 
            Dictionary<string, object> model = new Dictionary<string, object>{};
            model.Add("Engineers",_db.Engineers.ToList());
            model.Add("Machines",_db.Machine.ToList());
            
            return View(model);
        } 
    }
}