using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pierreavenant.Models;

namespace pierreavenant.Controllers
{
    public class WineController : Controller
    {
        public IActionResult Index()
        {
            List<WineModel> wine = new List<WineModel>()
            {
                new WineModel
                {
                    Manufacturer = "Meerlust",
                    Title = "Rubicon"
                },
                new WineModel
                {
                    Manufacturer = "Hermanus Pietersfontein",
                    Title = "Die Arnoldus"
                },
                new WineModel
                {
                    Manufacturer = "Doran",
                    Title = "Romney D"
                },
                new WineModel
                {
                    Manufacturer = "Springfield",
                    Title = "A Work Of Time"
                },
                new WineModel
                {
                    Manufacturer = "Kaiken",
                    Title = "Cab Sav"
                }
            };
            return View(wine);
        }
    }
}