using System.ComponentModel.DataAnnotations;

namespace CarGarageParkingApp.Models
{
    public class Garage
    {
        public int GarageId { get; set; }

        [Required (ErrorMessage = "Garage name is required.")]
        [StringLength(100, ErrorMessage = "Garage name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Garage location is required.")]
        [StringLength(200, ErrorMessage = "Garage location cannot be longer than 200 characters.")]
        public string Location { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater than 0")]
        public int Capacity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Current occupancy cannot be negative")]
        public int CurrentOccupancy { get; set; }
        public int AvailableSpots { get 
            {
                return Capacity - CurrentOccupancy;
            } 
        }
        public ICollection<VehicleInGarage> VehiclesInGarage { get; set; } = new List<VehicleInGarage>();
        public bool IsFull { get 
            {
                return CurrentOccupancy >= Capacity;
            } 
        }

    }
}
