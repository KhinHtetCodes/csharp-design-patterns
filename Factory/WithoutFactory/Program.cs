using System;

namespace WithoutFactory
{
    public interface IProduct
    {
        string Operation();
    }

    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("Using Product1");
            // client know which product is created
            ClientCode(new ConcreteProduct1());

            Console.WriteLine();

            Console.WriteLine("Using Product2");
            ClientCode(new ConcreteProduct2());
        }

        public void ClientCode(IProduct product)
        {
            Console.WriteLine(
                "Client: Working with "
                + product.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}