using System.ComponentModel.DataAnnotations;

namespace CarGarageParkingApp.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "Licence plate is reqired")]
        [StringLength(15, ErrorMessage = "Licence plate cannot be longer than 15 characters")]
        public string LicencePlate { get; set; }
        public int? OwnerId { get; set; }
        public Owner? Owner { get; set; }

    }
}
