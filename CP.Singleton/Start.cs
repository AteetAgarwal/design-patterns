using System;
using System.Threading;

namespace CP.Singleton
{
    //Important article --> https://csharpindepth.com/Articles/Singleton
    class Start
    {
        static void Main(string[] args)
        {
            CallingNaiveSingleton();
            CallingThreadSafeSingleton();
        }

        static void CallingNaiveSingleton()
        {
            // The client code.
            NaiveSingleton s1 = NaiveSingleton.GetInstance();
            NaiveSingleton s2 = NaiveSingleton.GetInstance();
            if (s1 == s2)
            {
                Console.WriteLine("Naive Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Naive Singleton failed, variables contain different instances.");
            }
        }

        static void CallingThreadSafeSingleton()
        {
            // The client code.
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
