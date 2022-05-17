using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class CargoShip : Ship
    {
        public CargoShip(int speed) : base(speed) 
        {
            FuelType = "diesel";
            CrewAmount = 20;
            LoadCapacity = 5200;
        }
    }
}
