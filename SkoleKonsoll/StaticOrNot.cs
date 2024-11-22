using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleKonsoll
{
    internal class StaticOrNot
    {
        // Main()

        //StaticOrNot.StaticHello();

        //StaticOrNot newInstance = new StaticOrNot();
        //newInstance.NonStaticHello();

        public void NonStaticHello()
        {
            Console.WriteLine("Hello, this is a non-static method call.");
        }

        public static void StaticHello()
        {
            Console.WriteLine("Hello, this is a static method call.");
        }
    }
}
