using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    /* This isn't really a logic class, as it only gets information about what vehicle the user wants to create. 
     * It shouldn't be necessary to have a class on its own to interact with the user. Simply have it as a method in the main-class */
    class Logics
    {
        // these variables become local variables(method variables) in the UserPrompt()
        public string doors;
        public string wheels;
        public string model;
        public string enginesize;
        public string type;


        public void UserPrompt()
        {
            //Begins the process of creating a new vehicle entry.
            Console.WriteLine("Please type the number that corresponds to the type of Vehicle");
            Console.WriteLine("Car = 1");
            Console.WriteLine("Truck = 2");
            Console.WriteLine("Motorcycle = 3");
            type = Console.ReadLine(); //Used to hold the type of vehicle.

            //Vehicle type is compared to make sure it fits within the criteria. While loop continues while 1,2 or 3 is not input.
            while ((type != "1") & (type != "2") & (type != "3"))
            {
                //User is prompted again repeatedly if they input incorrect values.
                Console.WriteLine("Invalid input. Please try again");
                Console.WriteLine(" ");
                Console.WriteLine("Please type the number that corresponds to the type of Vehicle");
                Console.WriteLine("Car = 1");
                Console.WriteLine("Truck = 2");
                Console.WriteLine("Motorcycle = 3");

                type = Console.ReadLine();
            }
            //Clears the console window to prevent clutter.
            Console.Clear();

            //Person inputs the Model of the Vehicle.
            Console.WriteLine("Please enter the Model of the Vehicle");
            model = Console.ReadLine();

            //Person inputs the EngineSize of the vehicle.
            Console.WriteLine("Please enter the Enginesize");
            enginesize = Console.ReadLine();

            //Depending on the type of vehicle, it'll either have 4,2 or many more tires(on a truck).
            if (type == "1")
            {
                wheels = "4";
            }
            else if (type == "3")
            {
                wheels = "2";
            }
            else
            {
                Console.WriteLine("Please input the amount of wheels the Truck has.");
                wheels = Console.ReadLine();

            }

            if (type != "3")
            {
                Console.WriteLine("How many doors does the vehicle have");
                doors = Console.ReadLine();
            }

            //Used for testing.
            //Console.WriteLine(model);
            //Console.WriteLine(enginesize);
            //Console.WriteLine(wheels);
            //Console.WriteLine(doors);
            //model = Console.ReadLine();


        }


    }
}
