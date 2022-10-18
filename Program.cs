using System;

namespace Labb_2_Arv_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Formatting Class(name, colour)
            var c = new Cat();
            var bD = new Bulldog("Jeffrey", "White");
            var fLH = new FinnishLapphund("Stella", "Black");

            c.MakeSound();
            bD.MakeSound();
            fLH.Jump();
        }
    }
}
