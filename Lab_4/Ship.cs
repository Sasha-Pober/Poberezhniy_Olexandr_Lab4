using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    interface IShip
    {
        string GetFuelType();
        int GetLoadCapacity();
        void Refueling();
        int GetCurrentSpeed();
    }
    abstract class Ship : IShip
    {
        protected int Speed { get; set; }
        protected int LoadCapacity { get; set; }
        protected string FuelType { get; set; }
        protected int CrewAmount { get; set; }

        public Ship (int speed)
        {
            Speed = speed;
        }

        public string GetFuelType() =>  $"Fuel type: {FuelType}";

        public int GetLoadCapacity() => LoadCapacity - CrewAmount * 80;

        public void Refueling() => Console.WriteLine($"The ship: {GetType().Name} was succesfully refueled\n");

        public int GetCurrentSpeed() => Speed;

        public void ShowStats()
        {
            Console.WriteLine($"{this.GetType().Name} has \n{this.GetFuelType()},\n{CrewAmount} members in crew,\n{this.GetLoadCapacity()}kg load capacity,\nand is going with speed {this.GetCurrentSpeed()} knots\n");
        }

    }
}
