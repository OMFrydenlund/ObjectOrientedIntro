using System.Security.Cryptography.X509Certificates;

namespace SkoleKonsoll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pokemon snorlax = new Pokemon("Snorlax", 98, "Normal", "Bash");           
            snorlax.ShowPokemonInfo();

            Console.ReadLine();
        }

    }
}
