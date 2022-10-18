using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal class Maple : Tree
    {
        public Maple(int growth = 0)
        {
            _growRate = 2;
            _sizeLimit = 20;
            _growth = growth;
            _name = "Maple";
        }
    }
}
