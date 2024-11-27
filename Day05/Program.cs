using System;
namespace Day05
{
    class Program
    {
        public static void Main()
        {
            GeoShape shape1 = new(5, 9); 
            Console.WriteLine();
            GeoShape shape2 = new Square(5, 9); 
            Console.WriteLine();
            GeoShape shape3 = new Triangle(5, 9); 
            Console.WriteLine();
            Circle shape4 = new Circle(5); 



           // Animal anima = new("Animal"); // Can  
            Console.WriteLine(); 
            Animal cat = new Cat("Tiddy"); // Late Binding
            Console.WriteLine();
            Animal dog = new Dog("Pluto", "German Shepherd"); // Late Binding
            Console.WriteLine(); 


            cat.MakeSound();
            dog.MakeSound();
        }
    }
}