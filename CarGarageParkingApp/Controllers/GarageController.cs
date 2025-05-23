using CarGarageParkingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarGarageParkingApp.Controllers
{
    public class GarageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private IEnumerable<Garage> ShowAllGarages()
        {
            List<Garage> listOfGarages = new List<Garage>();
            Garage g1 = new Garage();
            g1.GarageId = 1;
            g1.Name = "Garage 1";
            g1.Location = "Location 1";
            g1.Capacity = 100;
            g1.CurrentOccupancy = 50;

            listOfGarages.Add(g1);

            Garage g2 = new Garage();
            g2.GarageId = 2;
            g2.Name = "Garage 2";
            g2.Location = "Location 2";
            g2.Capacity = 200;
            g2.CurrentOccupancy = 150;
            listOfGarages.Add(g2);

            return listOfGarages;


        }
    }
}
