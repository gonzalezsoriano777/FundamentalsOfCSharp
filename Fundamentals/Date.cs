using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Date
    {
        public static void DateTiming()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Hour: {0}", now.Minute);

        }
    }
}
