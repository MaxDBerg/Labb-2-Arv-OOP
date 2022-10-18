using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal class Cat : Mammal
    {
        //Fields
        public bool _tail { get; set; }

        //Constructor
        public Cat(string name = "", string colour = "")
        {
            _race = "Cat";
            _name = name;
            _colour = colour;
            _tail = true;
            _tameOrWild = "Tame";
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

}
