using System;

namespace CP.FactoryMethod
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            var creator1 = new ConcreteCreator1();
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator1.SomeOperation());

            Console.WriteLine("");

            var creator2 = new ConcreteCreator2();
            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator2.SomeOperation());
        }
    }
}
