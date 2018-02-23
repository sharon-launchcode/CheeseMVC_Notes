using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;

namespace CheeseMVC.Controllers {
    public class CheeseController : Controller {
        public static Cheese Mozarella = new Cheese("Mozarella", "Delicious in string form", 4);
        public static Cheese Meunster = new Cheese("Meunster", "Perfect for saltines", 5);
        public static List<Cheese> Cheeses = new List<Cheese> { Mozarella, Meunster };
        
        public IActionResult Index() {
            ViewBag.Cheeses = Cheeses; // adds the Cheeses List to the ViewBag for use in the View
            return View();
        }

        public IActionResult Add() {
            return View();
        }
    }
}
