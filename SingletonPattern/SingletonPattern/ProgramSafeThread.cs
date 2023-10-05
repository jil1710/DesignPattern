using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class ProgramSafeThread
    {
        static void Main(string[] args)
        {

            // Run Parallel to see the nature of SingletonWithTreadSafe class. The following Code will Invoke both methods Parallely using two different Threads
            Parallel.Invoke(
                //Let us Assume ABC method is Invoked by Thread-1
                () => ABC(),
                //Let us Assume XYZ method is Invoked by Thread-2
                () => XYZ()
                );

            Console.ReadKey();

        }

        private static void ABC()
        {
            SingletonWithTreadSafe instance3 = SingletonWithTreadSafe.GetSingletonInstanceWithSafeThread();
            instance3.DoSomeTask();
        }

        private static void XYZ()
        {
            SingletonWithTreadSafe instance4 = SingletonWithTreadSafe.GetSingletonInstanceWithSafeThread();
            instance4.DoSomeTask();
        }
    }
}
