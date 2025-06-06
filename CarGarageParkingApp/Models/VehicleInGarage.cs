﻿using CarGarageParking.Util;
using System.ComponentModel.DataAnnotations;

namespace CarGarageParkingApp.Models
{
    public class VehicleInGarage
    {
        public int VehicleInGarageId { get; set; }

        [Required(ErrorMessage = "Vehicle ID is required.")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        [Required(ErrorMessage = "Garage ID is required.")]
        public int GarageId { get; set; }
        public Garage Garage { get; set; }

        [Required(ErrorMessage = "Entry time is required.")]
        [DataType(DataType.DateTime)]
        public DateTime EntryTime { get; set; }

        [DateGreaterThan("EntryTime", ErrorMessage = "Exit time must be greater than entry time.")]
        [DataType(DataType.DateTime)]
        public DateTime? ExitTime { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "HourlyRate rate must be greather than zero.")]
        public decimal HourlyRate { get; set; }
        public int? OwnerId { get; set; }
        public Owner? Owner { get; set; }
        public bool IsVehicleStillInGarage { get; set; } = true;

    }
}
