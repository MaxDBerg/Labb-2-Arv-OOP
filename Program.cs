using System;

namespace Labb_2_Arv_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            d.Sleep();
        }
    }
    internal abstract class Animal
    {
        //Fields
        public int _legs { get; set; }
        public int _head { get; set; }
        public bool _horns { get; set; }
        public string _name { get; set; }
        public string _colour { get; set; }

        //Constructor
        public Animal()
        {
            _legs = 4;
            _head = 1;
            _horns = false;
            _name = "animal";
            _colour = "black";
        }

        //Methods
        public virtual void Sleep()
        {
            Console.WriteLine("{0} Sleeps", _name);
        }
        public virtual void Eat()
        {
            Console.WriteLine("{0} Eats", _name);
        }
        public virtual void Walk()
        {
            Console.WriteLine("{0} Walks", _name);
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("boo... boo... boo...");
        }
    }
    internal class Cat : Animal
    {
        //Fields
        public bool _tail { get; set; }

        //Constructor
        public Cat()
        {
            _legs = 4;
            _head = 1;
            _horns = false;
            _name = "cat";
            _colour = "brown";
            _tail = true;
        }

        //Methods
        public override void MakeSound()
        {
            Console.WriteLine("meow... meow... meow...");
        }
        public void Attack()
        {
            Console.WriteLine("Cat Attacks!");
        }
    }
    internal class Dog : Animal
    {
        //Fields
        public bool _smile { get; set; }

        //Constructor
        public Dog()
        {
            _legs = 4;
            _head = 1;
            _horns = false;
            _name = "dog";
            _colour = "brown";
            _smile = true;
        }

        //Methods
        public override void MakeSound()
        {
            Console.WriteLine("Wooof! Wooof! Wooof!");
        }
        public virtual void Bite()
        {
            Console.WriteLine("{0} Bites!", _name);
        }
    }
    internal class Bulldog : Dog
    {
        public bool _nose { get; set; }
        public Bulldog()
        {
            _name = "bulldog";
            _colour = "white";
            _smile = false;
            _nose = false;
        }
        public override void Bite()
        {
            Console.WriteLine("{0} can't bite!?", _name);
        }
        public void Roll()
        {
            Console.WriteLine("{0} Rolls down the hill", _name);
        }
    }
}
