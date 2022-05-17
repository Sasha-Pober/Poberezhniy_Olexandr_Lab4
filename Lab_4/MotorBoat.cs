using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class MotorBoat : Ship
    {
        public MotorBoat(int speed) : base(speed) 
        {
            FuelType = "gasoline";
            CrewAmount = 5;
            LoadCapacity = 700;
        }
    }
}
