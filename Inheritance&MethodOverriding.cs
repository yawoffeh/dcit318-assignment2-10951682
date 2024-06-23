using System;

namespace AnimalSounds
{
    // Base class
    public class Animal
    {
        // Virtual method that can be overridden in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog that overrides the MakeSound() method
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat that overrides the MakeSound() method
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            // Call the MakeSound() method on each instance
            myAnimal.MakeSound(); // Outputs: Some generic sound
            myDog.MakeSound();    // Outputs: Bark
            myCat.MakeSound();    // Outputs: Meow

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
