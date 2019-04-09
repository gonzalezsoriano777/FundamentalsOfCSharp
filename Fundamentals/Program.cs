using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class AudiCar
    {

        // Learned to create strings that can be called through the console, must be outside of the Main func. to be properly called
        string location;
        string model;

        static void Main(string[] args)
        {

            // New AudiCar object
            AudiCar myAudi = new AudiCar();
            
             // Calling different methods from the class itself
             myAudi.location = "Germany";
             myAudi.model = "RS7";

            // Calling the location
            Console.WriteLine(myAudi.location);
            Console.WriteLine(myAudi.model);

        }

        // Following code are all public classes

        public void CreateCar()
        {
            Console.WriteLine("Welcome to your new and improved Audi, sent from Germany");
        }

    }
}
