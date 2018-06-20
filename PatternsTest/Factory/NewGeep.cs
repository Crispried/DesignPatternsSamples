using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Factory
{
    public class NewGeep : ICar
    {
        public void Drive()
        {
            Console.WriteLine("My speed is 120 km/h!");
        }
        public void Stop()
        {
            Console.WriteLine("I am stopping in 2 sec!");
        }
    }
}
