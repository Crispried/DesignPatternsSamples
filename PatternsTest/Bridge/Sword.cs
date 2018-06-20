using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Bridge
{
    public class Sword : IWeapon
    {
        public void GiveBonus(CharachterClass charachterClass)
        {
            if (charachterClass.GetClass == "Paladin")
            {
                Console.WriteLine("Add 30 extra def and 100 physical dmg!");
            }
            else
            {
                Console.WriteLine("Default Sword");
            }
        }
        public void a()
        {
            
            Console.WriteLine("a");
        }
        public static void b()
        {
            Console.WriteLine("b");
        }
    }
}
