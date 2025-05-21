﻿namespace CarGarageParkingApp.Models
{
    public class Garage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int CurrentOccupancy { get; set; }
        public int AvilableSpots { get 
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
