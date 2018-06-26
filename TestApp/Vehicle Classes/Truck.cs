using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{

    class Truck : Vehicle
    {
        string doors;
        string type = "Truck";

        public Truck(string doors, string Wheels, string EngineSize, string Model)
        {
            this.Enginesize = EngineSize;
            this.Wheels = Wheels;
            this.Model = Model;
            this.doors = doors;
        }


    }
}
