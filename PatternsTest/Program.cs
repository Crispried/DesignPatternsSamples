using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsTest.Singleton;
using PatternsTest.Factory;
using PatternsTest.AbstractFactory;
using PatternsTest.Decorator;
using PatternsTest.Adapter;
using PatternsTest.Facade;
using PatternsTest.Observer;
using PatternsTest.State;
using PatternsTest.Strategy;
using PatternsTest.Bridge;
using PatternsTest.NullObject;
using System.Diagnostics;

namespace PatternsTest
{
    class Program
    {
        public static void SingletonDemo()
        {
            int numberOfIterations = Convert.ToInt32(Console.ReadLine());
            var timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < numberOfIterations; i++)
            {
                //Singleton.Singleton.GetInstance().Print(i);
                Singleton.JustStaticClass.Print(i);
            }
            timer.Stop();
            var elapsedTime = timer.ElapsedMilliseconds;
            Console.WriteLine("ElapsedTime: " + elapsedTime);
            Console.ReadKey();
        }
        public static void FactoryDemo()
        {
            ICar Car1 = CarSelector.GetInstance().GetCar(RoadType.City);
            ICar Car2 = CarSelector.GetInstance().GetCar(RoadType.Offroad);
            ICar Car3 = CarSelector.GetInstance().GetCar(RoadType.Mountains);
            Car1.Drive();
            Car1.Stop();
            Car2.Drive();
            Car2.Stop();
            Car3.Drive();
            Car3.Stop();
        }
        public static void AbstractFactoryDemo()
        {
            ISoldierFactory Team1 = TeamSelector.GetInstance().GetTeam(TeamColour.Blue);
            ISoldierFactory Team2 = TeamSelector.GetInstance().GetTeam(TeamColour.Red);
            Console.WriteLine("The First Team!");
            Team1.CreateAssault().FastShot();
            Team1.CreateHeavy().LaunchRocket();
            Team1.CreateSniper().AimShot();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("The second Team!");
            Team2.CreateAssault().FastShot();
            Team2.CreateHeavy().LaunchRocket();
            Team2.CreateSniper().AimShot();
        }
        public static void DecoratorDemo(bool showColourAndBorder)
        {
            IComponent button;
            IComponent window;
            if (showColourAndBorder)
            {
                button = new BorderDecorator(new Button());
                button.draw();
                window = new ColourDecorator(new Window());
                window.draw();
            }
            else
            {
                button = new Button();
                button.draw();
                window = new Window();
                window.draw();
            }
        }
        public static void AdapterDemo()
        {
            List<object> stringObjects = new List<object>();
            stringObjects.Add("obj1");
            stringObjects.Add("obj2");
            stringObjects.Add("obj3");
            List<object> intObjects = new List<object>();
            intObjects.Add(1);
            intObjects.Add(2);
            intObjects.Add(3);
            IObjectDestroyer objDestroyAdapter = new ObjectDestroyerAdapter();
            objDestroyAdapter.DestroyAllObjects(stringObjects);
            objDestroyAdapter.DestroyAllObjects(intObjects);
        }
        public static void FacadeDemo()
        {
            Mission Mission = new Mission();
            Mission.MakeTheMission();
        }
        public static void ObserverDemo()
        {
            IGameController GameController = new GameController();
            Player1 Player1 = new Player1();
            Player2 Player2 = new Player2();
            Player3 Player3 = new Player3();
            GameController.AddPlayer(Player1);
            GameController.AddPlayer(Player2);
            GameController.AddPlayer(Player3);
            GameController.NotifyPlayer(PlayerState.Moving, Player1);
            GameController.NotifyPlayer(PlayerState.Waiting, Player2);
            GameController.NotifyPlayer(PlayerState.Waiting, Player3);
        }
        public static void StateDemo()
        {
            MonsterContext Context = new MonsterContext();
            IMonsterState SleepState = new SleepState();
            IMonsterState AttackState = new AttackState();
            IMonsterState SpeakState = new SpeakState();
            Context.SetState(AttackState);
            Context.Action();
            Context.SetState(SleepState);
            Context.Action();
            Context.SetState(SpeakState);
            Context.Action();
        }
        public static void StrategyDemo()
        {
            ModeController GameController = new ModeController();
            GameController.CreateGame(new ClassicMode());
            GameController.CreateGame(new DeathmatchMode());
            GameController.CreateGame(new ClanWarMode());
        }
        public static void BridgeDemo()
        {
            CharachterClass Paladin = new Paladin();
            CharachterClass Assasin = new Assasin();
            CharachterClass Wizzard = new Wizzard();
            IWeapon Staff = new Staff();
            IWeapon Sword = new Sword();
            IWeapon Claws = new Claws();
            Staff.GiveBonus(Wizzard);
            Sword.GiveBonus(Paladin);
            Claws.GiveBonus(Assasin);
            Claws.GiveBonus(Wizzard);
        }
        public static void NullObjectDemo()
        {
            ISpeakable notNullPlayer = new Player();
            notNullPlayer.WritePostMessage("Hello everybody!");
            ISpeakable nullPlayer = new NullPlayer();
            // if we would initialize it as null (not NullPlayer) we get exception.
            nullPlayer.WritePostMessage("Hello everybody!");

        }
        static void Main(string[] args)
        {
            SingletonDemo();
            //FactoryDemo();
            //AbstractFactoryDemo();
            //DecoratorDemo(true);
           // AdapterDemo();
            //FacadeDemo();
            //ObserverDemo();
            //StateDemo();
            //StrategyDemo();
            //BridgeDemo();
            //NullObjectDemo();
        }
    }
}
