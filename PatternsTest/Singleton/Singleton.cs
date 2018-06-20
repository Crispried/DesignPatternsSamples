using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Singleton
{
    public class Singleton
    {
        private static Singleton Instance;     
        private Singleton() { } 
        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }
        public void Print(int i)
        {
            Console.WriteLine("Execution number: " + i);
        }
    }
}
