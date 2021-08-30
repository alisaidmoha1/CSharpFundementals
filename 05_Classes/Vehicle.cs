using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Spaceship, Plane }
    public class Vehicle // class is just a type of data object, you can make whatever class you want
    {
        public Vehicle() { }
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();



        }

        // 1- Access modidied => Where can this be seen
        // 2- type => Type of the property as a held value
        // 3 Name => Name of the property method, Pascal case
        // 4 - Getters and setters
        // 1    2     3      4
        public string Make { get; set; } // this is a property
        public String Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; } // we can use the enum above as aproperty.
        public bool IsRunning { get; private set; }// get is get the value, set is assign a value.

        public void TurnOn()
        {
            IsRunning = true;

        }

        public void TurnOff()
        {
            IsRunning = false;
        }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void TurnRight()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }

        public void TurnLeft()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOn();

        }

        public void TurnOnHazards()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }

        public void ClearIndicators()
        {
            LeftIndicator.TurnOff();
            RightIndicator.TurnOff();
        }
    }
        public class Indicator
        {
            public bool IsFlashing { get; private set; }

            public void TurnOn()
            {
                IsFlashing = true;
            }

            public void TurnOff()
            {
                IsFlashing = false;
            }
        }
    

}

