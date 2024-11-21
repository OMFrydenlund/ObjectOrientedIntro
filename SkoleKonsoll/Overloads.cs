using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleKonsoll
{
    internal class Overloads
    {
        // Main()

        //int peopleCounter = 0;

        //Console.Write("Hva heter du: ");
        //    string nameInput = Console.ReadLine();

        //Overloads.PrintWelcomeMessage(nameInput);
        //    Overloads.PrintWelcomeMessage(nameInput, peopleCounter + 1);

        public static void PrintWelcomeMessage(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Hei og velkommen.");
            }
            else
            {
                Console.WriteLine($"Hei og velkommen {name}.");
            }           
        }

        public static void PrintWelcomeMessage(string name, int queueCount)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Hei og velkommen. Du er nummer {queueCount} i køen.");
            }
            else
            {
                Console.WriteLine($"Hei og velkommen {name}. Du er nummer {queueCount} i køen.");
            }                      
        }       
    }
}
