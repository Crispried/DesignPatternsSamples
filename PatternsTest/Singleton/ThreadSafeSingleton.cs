using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Singleton
{
    public sealed class ThreadSafeSingleton
    {
        private static volatile ThreadSafeSingleton instance;
        private static object syncRoot = new Object();

        private ThreadSafeSingleton() { }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ThreadSafeSingleton();
                    }
                }

                return instance;
            }
        }

        public void Print(int i)
        {
            Console.WriteLine("Execution number: " + i);
        }
    }
}
