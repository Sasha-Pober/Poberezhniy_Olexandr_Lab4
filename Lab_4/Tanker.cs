using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Tanker : Ship
    {
        public Tanker(int speed) : base(speed) 
        {
            FuelType = "nuclear";
            CrewAmount = 100;
            LoadCapacity = 60000;
        }
    }
}
