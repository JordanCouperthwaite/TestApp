using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{

    class Motorcycle : Vehicle
    {
        private string type = "Motorcycle";

        public Motorcycle(string Wheels, string EngineSize, string Model)
        {
            this.Enginesize = EngineSize;
            this.Wheels = Wheels;
            this.Model = Model;
        }


    }
}
