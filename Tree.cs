using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal class Tree : Plants
    {
        public Tree(int growth = 0, string name = "")
        {
            _growRate = 2;
            _sizeLimit = 20;
            _growth = growth;
            _name = name;
        }
    }
}
