using System;

namespace SP.Decorator
{
    class Start
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
        }

        public class Client
        {
            // The client code works with all objects using the Component interface.
            // This way it can stay independent of the concrete classes of
            // components it works with.
            public void ClientCode(Component component)
            {
                Console.WriteLine("RESULT: " + component.Operation());
            }
        }
    }
}
