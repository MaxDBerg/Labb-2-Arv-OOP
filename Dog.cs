using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal abstract class Dog : Mammal
    {
        //Fields
        public bool _smile { get; set; }
        public bool _cute { get; set; }

        //Constructor
        public Dog()
        {
            _race = "Dog";
            _name = "Leff";
            _colour = "Brown";
            _smile = true;
            _cute = true;
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
        public Bulldog(string name, string colour)
        {
            _name = name;
            _colour = colour;
            _smile = false;
            _nose = false;
            _cute = false;
            _tameOrWild = "Tame";
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
    internal class FinnishLapphund : Dog
    {
        public bool _fluffy { get; set; }
        public FinnishLapphund(string name, string colour)
        {
            _name = name;
            _colour = colour;
            _smile = false;
            _cute = true;
            _fluffy = true;
            _tameOrWild = "Tame";
        }
        public override void Bite()
        {
            Console.WriteLine("{0} Doesn't bite :)", _name);
        }
        public void Jump()
        {
            Console.WriteLine("{0} Jumps!", _name);
        }
    }
}
