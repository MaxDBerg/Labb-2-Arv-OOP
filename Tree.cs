using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal class Tree : Plants
    {
        public bool _hasLeaves { get; set; }
        public Tree(int growth = 0)
        {
            _growRate = 2;
            _sizeLimit = 20;
            _growth = growth;
            _name = "Tree";
            _hasLeaves = true;
        }
    }
    internal class Pine : Tree
    {
        public Pine(int growth = 0)
        {
            _growRate = 2;
            _sizeLimit = 20;
            _growth = growth;
            _name = "Maple";
            _hasLeaves = false;
        }
    }
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
