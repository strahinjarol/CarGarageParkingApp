using System.ComponentModel.DataAnnotations;

namespace CarGarageParkingApp.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }

        [Required]
        public int OwmerId { get; set; }
        public Owner Owner { get; set; } 
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        [Range(0, double.MaxValue, ErrorMessage = "Credit must be graeter than zero.")]
        public decimal Credit { get; set; }
        public bool HasActiveMembership { get; set; }
    }
}
