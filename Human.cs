using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal class Human : Mammal
    {
        public Human(string name, string colour)
        {
            _race = "Human";
            _name = name;
            _colour = colour;
        }

        public void Programming()
        {
            Console.WriteLine("Look that human is programming... (╯°□°)╯  ┻━┻ ");
        }
    }
}
