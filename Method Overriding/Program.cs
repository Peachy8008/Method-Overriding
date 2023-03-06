using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Animal 
    {
        public virtual void Speak()
        {
            Console.WriteLine("Lmao funny noises");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog: *Woof*");
        }
    }

    class Cat : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("Cat: *Meow*");
        }
    }

    class Human : Animal 
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Human human = new Human();

            dog.Speak();
            cat.Speak();
            human.Speak();
        }
    }
}
