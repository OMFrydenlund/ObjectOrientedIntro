using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleKonsoll
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        public string AbilityName { get; set; }
        
        //is a constructor needed NOPE
        public void ShowPokemonInfo()
        {
            Console.WriteLine($"Name: {Name}\nLevel: {Level}\nType: {Type}\nAbility: {AbilityName}");
        }

        // kode nedenfor i Main()

        //Pokemon snorlax = new Pokemon();
        //snorlax.Name = "Snorlax";
        //snorlax.Level = 98;
        //snorlax.Type = "Normal";
        //snorlax.AbilityName = "Bash";

        //snorlax.ShowPokemonInfo();
    }
}
