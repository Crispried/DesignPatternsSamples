using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Factory
{
    public class CarSelector
    {
        private static CarSelector Instance;
        private CarSelector() { }
        public static CarSelector GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CarSelector();
            }
            return Instance;
        }
        public ICar GetCar(RoadType roadType)
        {
            ICar Car = null;
            switch (roadType)
            {
                case RoadType.City:
                    Car = new SportCar();
                    break;
                case RoadType.Offroad:
                    Car = new Geep();
                    break;
                case RoadType.Mountains:
                    Car = new NewGeep();
                    break;
            }
            return Car;
        }
    }
}
