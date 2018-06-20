using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Bridge
{
    public class Staff : IWeapon
    {
        public void GiveBonus(CharachterClass charachterClass)
        {
            if(charachterClass.GetClass == "Wizzard")
            {
                Console.WriteLine("Add 10 extra spells and 50 wiz dmg!");
            }
            else
            {
                Console.WriteLine("Default Staff");
            }               
        }
    }
}
