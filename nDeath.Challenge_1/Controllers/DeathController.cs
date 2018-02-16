using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using nDeath.Challenge_1.Models;

namespace nDeath.Challenge_1.Controllers
{
    public class DeathController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(Coefficients coefficient)
        {
            if (ModelState.IsValid)
            {
                List<Coordinate> cord = new List<Coordinate>();
                var imin = Coordinate.CoordinateXo(coefficient.B, coefficient.A) + coefficient.Min;
                var imax = Coordinate.CoordinateXo(coefficient.B, coefficient.A) + coefficient.Max;
                for (var i = imin; i <= imax; i += coefficient.S)
                {
                    var y = Coordinate.CoordinateY(i, coefficient.A, coefficient.B, coefficient.C);
                    cord.Add(new Coordinate(i, y));
                }
                ViewBag.Result = cord;
                ViewBag.IsRotated = coefficient.A < 0;
            }
            return View("Index");
        }


    }
}