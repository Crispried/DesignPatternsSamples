using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Factory
{
    public class Geep : ICar
    {
        public void Drive()
        {
            Console.WriteLine("My speed is 80 km/h");
        }
        public void Stop()
        {
            Console.WriteLine("I am stopping in 6 sec");
        }
    }
}
