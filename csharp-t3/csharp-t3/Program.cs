using csharp_t3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpt3
{
    enum CatColor
    {
        Red = 1,
        Blue = 2,
        Green = 3,
        Pink = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Doja", new DateTime(2022, 2, 10), (int)CatColor.Red);
            cat.setParent("BinZ","Juicy");
            cat.showInfo();
        }
    }
}