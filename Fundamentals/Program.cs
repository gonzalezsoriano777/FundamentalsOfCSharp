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

        // Private strings that can only be used in this class
        private string location;
        private string model;

        // Used GET and SET on both location and model to get both of them and assign them to a value assigned
        public string Location { get => location; set => location = value; }
        public string Model { get => model; set => model = value; }

        static void Main(string[] args)
        {

            // New AudiCar object
            AudiCar myAudi = new AudiCar();
            
             // Calling different methods from the class itself
             myAudi.Location = "Germany";
             myAudi.Model = "RS7";

            // Calling the location
            Console.WriteLine(myAudi.Location);
            Console.WriteLine(myAudi.Model);

        }

        // Following code are all public classes

        public void CreateCar()
        {
            Console.WriteLine("Welcome to your new and improved Audi, sent from Germany");
        }

    }
}
