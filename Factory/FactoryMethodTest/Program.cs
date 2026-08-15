using System;
namespace FactoryMethodTest
{
    /// <summary>
    /// Step 1
    /// </summary>
    public interface IProduct
    {
        string Operation();
    }

    /// <summary>
    /// Step 2
    /// </summary>

    abstract class Creator
    {
        // this will be object creation factory method for child class
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            // call the factorymethod to create a product obj
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with " + product.Operation();

            return result;
        }
    }

    /// <summary>
    /// Step 3
    /// </summary>

    // create obj creation class and overide factory method
    // if we need to add new creator class in future, just create another class and ovrride the factory method
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            // return an object that implements IProduct
            // return new ConcreteCreator1(); 
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            // return an object that implements IProduct
            // return new ConcreteCreator2(); 
            return new ConcreteProduct2();
        }
    }

    /// <summary>
    /// Step 4
    /// </summary>

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

    /// <summary>
    /// Step 5
    /// </summary>

    class Client
    {
        public static void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            // just call creator obj so the client dont know which prodcut is created
            ClientCode(new ConcreteCreator1());
            
            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        public static void ClientCode(Creator creator)
        {
               Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
        }
    }
}