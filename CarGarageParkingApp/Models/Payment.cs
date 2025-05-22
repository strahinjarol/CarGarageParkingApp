namespace CarGarageParkingApp.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal TotalCharge { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentTime { get; set; }
        public DateTime ExparationTime { get; set; } // This is the time + 15min when the payment expires and the vehicle must be removed from the garage or the payment must be renewed.
        public int VehicleInGarageId { get; set; }
        public VehicleInGarage VehicleInGarage { get; set; } = null!;
    }
}
