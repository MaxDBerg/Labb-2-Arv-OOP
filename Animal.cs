using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal abstract class Animal
    {
        //Fields
        public int _legs { get; set; }
        public string _race { get; set; }
        public bool _varmBlooded { get; set; }
        public string _name { get; set; }
        public string _colour { get; set; }

        //Constructor
        public Animal()
        {
            _legs = 4;
            _race = "Animal";
            _varmBlooded = false;
            _name = "Jeff";
            _colour = "Black";
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
    internal abstract class Mammal : Animal
    {
        public Mammal()
        {
            _varmBlooded = true;
        }
    }
    internal abstract class Reptile : Animal
    {
        public Reptile()
        {
            _varmBlooded = false;
        }
    }

}
