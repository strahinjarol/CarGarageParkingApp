using CarGarageParkingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarGarageParkingApp.Controllers
{
    public class OwnerController : Controller
    {
        public IActionResult Index(string firstName, string lastName, int? numberOfVehicles)
        {
            IEnumerable<Owner> owners = GetAllOwners();

            if(firstName != null)
            {
                owners = owners.Where(o => o.FirstName.Contains(firstName, StringComparison.OrdinalIgnoreCase));
            }
            if(lastName != null)
            {
                owners = owners.Where(o => o.LastName.Contains(lastName, StringComparison.OrdinalIgnoreCase));
            }
            if(numberOfVehicles.HasValue)
            {
                owners = owners.Where(o => o.Vehicles.Count == numberOfVehicles.Value);
            }

            return View(owners);
        }

        public IActionResult Details(int Id)
        {
            IEnumerable<Owner> owners = GetAllOwners();

            Owner singleOwner = owners.FirstOrDefault(o => o.OwnerId == Id);

            return View(singleOwner);

        }
        public IEnumerable<Owner> GetAllOwners()
        {
            List<Owner> owners = new List<Owner>();
            Owner owner1 = new Owner();
            owner1.OwnerId = 1;
            owner1.FirstName = "John";
            owner1.LastName = "Doe";
            owner1.Vehicles = new List<Vehicle>();
            Vehicle vehicle1 = new Vehicle();
            //vehicle1.VehicleId = 1;
            vehicle1.LicencePlate = "ABC123";
            owner1.Vehicles.Add(vehicle1);
            owners.Add(owner1);
            Owner owner2 = new Owner();
            owner2.OwnerId = 2;
            owner2.FirstName = "Jane";
            owner2.LastName = "Smith";
            owner2.Vehicles = new List<Vehicle>();
            Vehicle vehicle2 = new Vehicle();
            //vehicle2.VehicleId = 2;
            vehicle2.LicencePlate = "XYZ789";
            owner2.Vehicles.Add(vehicle2);
            Vehicle vehicle6 = new Vehicle();
            //vehicle6.VehicleId = 6;
            vehicle6.LicencePlate = "JKL012";
            owner2.Vehicles.Add(vehicle6);
            owners.Add(owner2);
            Owner owner3 = new Owner();
            owner3.OwnerId = 3;
            owner3.FirstName = "Alice";
            owner3.LastName = "Johnson";
            owner3.Vehicles = new List<Vehicle>();
            Vehicle vehicle3 = new Vehicle();
            //vehicle3.VehicleId = 3;
            vehicle3.LicencePlate = "LMN456";
            owner3.Vehicles.Add(vehicle3);
            Vehicle vehicle4 = new Vehicle();
            //vehicle4.VehicleId = 4;
            vehicle4.LicencePlate = "DEF321";
            owner3.Vehicles.Add(vehicle4);
            Vehicle vehicle5 = new Vehicle();
            //vehicle5.VehicleId = 5;
            vehicle5.LicencePlate = "GHI654";
            owner3.Vehicles.Add(vehicle5);
            owners.Add(owner3);

            return owners;
        }
    }
}
