using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    abstract internal class Animal
    {
        protected string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("base ctor");

        }

        public virtual void MakeSound()
        {
            Console.WriteLine("....");
        }
    }

    class Dog : Animal
    {
        public string Species { get; set; }

        public Dog(string name, string species) : base(name)
        {
            Name = "Dog";
            Species = "";

            Console.WriteLine("derieved1 ctor");

        }
        public override void MakeSound()
        {
            Console.WriteLine("WOOF WOOF!");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            Name = "Kitty";
            Console.WriteLine("derieved2 ctor");

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow!");
        }
    }
}
