using System;

namespace MovableExample
{
    // Defining the IMovable interface with the Move() method
    public interface IMovable
    {
        void Move();
    }

    // Creating the Car class that implements the IMovable interface
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Creating the Bicycle class that implements the IMovable interface
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Car and Bicycle
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            // Calling the Move() method on each instance
            myCar.Move();      // Outputs: Car is moving
            myBicycle.Move();  // Outputs: Bicycle is moving

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
