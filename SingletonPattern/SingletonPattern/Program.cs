namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of SingletonWithoutTreadSafe 
            // If multiple thread is running parallel then it's will create multiple instance so this example is not thread safe.

            //SingletonWithoutTreadSafe instance1 = SingletonWithoutTreadSafe.GetSingletonInstance();
            //instance1.DoSomeTask();

            //Invoke again it will give same object but if we run parallel then it will create multiple instance
            //SingletonWithoutTreadSafe instance2 = SingletonWithoutTreadSafe.GetSingletonInstance();
            //instance2.DoSomeTask();


            // Run Parallel to see the nature of SingletonWithoutTreadSafe class. The following Code will Invoke both methods Parallely using two different Threads
            Parallel.Invoke(
                //Let us Assume ABC method is Invoked by Thread-1
                () => ABC(),
                //Let us Assume XYZ method is Invoked by Thread-2
                () => XYZ()
                );

            Console.ReadLine();
        }

        private static void ABC()
        {
            SingletonWithoutTreadSafe instance3 = SingletonWithoutTreadSafe.GetSingletonInstance();
            instance3.DoSomeTask();
        }

        private static void XYZ()
        {
            SingletonWithoutTreadSafe instance4 = SingletonWithoutTreadSafe.GetSingletonInstance();
            instance4.DoSomeTask();
        }
    }
}