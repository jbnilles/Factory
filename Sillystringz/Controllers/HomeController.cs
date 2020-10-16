using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sillystringz.Models;
namespace Sillystringz.Controllers
{
    public class HomeController : Controller
    {
        private readonly SillystringzContext _db;
        public HomeController(SillystringzContext db)
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