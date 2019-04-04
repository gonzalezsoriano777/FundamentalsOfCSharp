using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class AudiCar
    {
        static void Main(string[] args)
        {
            AudiCar myAudi = new AudiCar();
            
             // Calling different methods from the class itself
             myAudi._location = "Germany";
             myAudi._model = "RS7";

            Console.WriteLine("Welcome to your new and improved Audi, sent from Germany");
        }
    }
}
