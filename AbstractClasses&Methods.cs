using System;

namespace ShapeArea
{
    // Abstract base class
    public abstract class Shape
    {
        // Abstract method to be implemented in derived classes
        public abstract double GetArea();
    }

    // Derived class Circle that implements GetArea() method
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle that implements GetArea() method
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Circle and Rectangle
            Circle myCircle = new Circle(4.0);
            Rectangle myRectangle = new Rectangle(5.0, 8.0);

            // Displaying the areas of the Circle and Rectangle
            Console.WriteLine($"The area of the circle is: {myCircle.GetArea()}");
            Console.WriteLine($"The area of the rectangle is: {myRectangle.GetArea()}");

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
