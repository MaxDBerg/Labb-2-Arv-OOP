using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal class Plants
    {
        //Fields
        public int _growRate { get; set; }
        public int _sizeLimit { get; set; }
        public int _age { get; set; }
        public string _name { get; set; }
        public string _preferedHabitat { get; set; }
        public bool _fruits { get; set; }

        //Constructor
        public Plants()
        {
            _growRate = 0;
            _sizeLimit = 0;
            _age = 0;
            _name = "Plant";
            _preferedHabitat = "Anywhere";
            _fruits = false;
        }
        public void Grow(int growth)
        {
            if (_growRate > growth && growth <= 0 && growth + _age != _sizeLimit)
            {
                Console.WriteLine("The {0} grew a bit ^^", _name);
                _age += growth;
            }
        }
        public void Sway()
        {
            Console.WriteLine("The {0} sways in the wind", _name);
        }
        public void Sit()
        {
            Console.WriteLine("The {0} sits there...", _name);
        }
    }
}
