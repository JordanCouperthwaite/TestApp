using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Car : Vehicle
    {
        // private-declared 
        string doors;
        string type = "Car";

        public Car(string doors, string Wheels, string EngineSize, string Model, string type) // wheels, engineSize, model. 
        {
            this.Enginesize = EngineSize;
            this.Wheels = Wheels;
            this.Model = Model;
            this.doors = doors;
        }
        
    }
}
