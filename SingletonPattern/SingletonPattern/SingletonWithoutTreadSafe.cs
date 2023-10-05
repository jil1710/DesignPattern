using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonWithoutTreadSafe
    {
        private static int Counter = 0;

        private static SingletonWithoutTreadSafe Instance = null;
        private SingletonWithoutTreadSafe() 
        {
            Counter++;
            Console.WriteLine($"Counter : {Counter}");
        }


        public static SingletonWithoutTreadSafe GetSingletonInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonWithoutTreadSafe();
            }
            return Instance;
        }


        /// <summary>
        /// All the method of this class call or invoke by same instance 
        /// </summary>
        public void DoSomeTask()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
