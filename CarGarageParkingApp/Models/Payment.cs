using System.ComponentModel.DataAnnotations;

namespace CarGarageParkingApp.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Total charge must be greather than zero")]
        //[IntTypeGreaterThan("VehicleHorlyRate", ErrorMessage = "Total charge   must be greater or equal than hourly rate.")]
        public decimal TotalCharge { get; set; }
        public bool IsPaid { get; set; }

        [Required(ErrorMessage = "Payment time is required.")]
        [DataType(DataType.DateTime)]
        public DateTime PaymentTime { get; set; }

        //[DateGreaterThan("PaymentTime", ErrorMessage = "Expiration date must be greater than payment time.")]
        [DataType(DataType.DateTime)]
        public DateTime ExparationTime { get; set; } // This is the time + 15min when the payment expires and the vehicle must be removed from the garage or the payment must be renewed.

        [Required(ErrorMessage = "Vehicle in garage ID is required.")]
        public int VehicleInGarageId { get; set; }

        public VehicleInGarage VehicleInGarage { get; set; } = null!;
    }
}
