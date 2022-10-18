using System;
using System.Text;

namespace Labb_2_Arv_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Formatting Class(name, colour)
            var c = new Cat("Chilli", "Red");
            var bD = new Bulldog("Jeffrey", "White");
            var fLH = new FinnishLapphund("Stella", "Black");
            var h = new Human("Max", "White");

            h.Programming();
            c.MakeSound();
            bD.MakeSound();
            fLH.Jump();
        }
    }
}
