using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class SingletonWithTreadSafe
    {
        private static int Counter = 0;

        //This will make the Singleton Instance Lazy Loading
        //Lazy Object are Thread-Safe by default
        private static readonly Lazy<SingletonWithTreadSafe> Instance = new Lazy<SingletonWithTreadSafe>(() => new SingletonWithTreadSafe());

        public static SingletonWithTreadSafe GetSingletonInstanceWithSafeThread()
        {
            return Instance.Value;
        }


        private SingletonWithTreadSafe()
        {
            Counter++;
            Console.WriteLine($"Counter : {Counter}");
        }

        public void DoSomeTask()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
