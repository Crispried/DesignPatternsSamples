using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Bridge
{
    public class Claws : IWeapon
    {
        public void GiveBonus(CharachterClass charachterClass)
        {
            if (charachterClass.GetClass == "Assasin")
            {
                Console.WriteLine("Add 10% extra critical chance and 100% critical dmg!");
            }
            else
            {
                Console.WriteLine("Default Claws");
            }
        }
    }
}
