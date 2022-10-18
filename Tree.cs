using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal class Tree : Plants
    {
        public bool _hasLeaves { get; set; }
        public Tree()
        {
            _growRate = 2;
            _sizeLimit = 20;
            _name = "Tree";
            _hasLeaves = true;
        }
    }
    internal class Pine : Tree
    {
        public Pine()
        {
            _growRate = 5;
            _sizeLimit = 100;
            _name = "Maple";
            _hasLeaves = false;
        }
    }
    internal class Maple : Tree
    {
        public Maple()
        {
            _growRate = 1;
            _sizeLimit = 40;
            _name = "Maple";
        }
    }
}
