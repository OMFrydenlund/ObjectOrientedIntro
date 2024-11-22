using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleKonsoll
{
    internal class Pokemon
    {       
        string Name { get; set; }
        int Level { get; set; }
        string Type { get; set; }
        string AbilityName { get; set; }
        
        public Pokemon(string name, int level, string type, string abilityName)
        {
            Name = name;
            Level = level;
            Type = type;
            AbilityName = abilityName;
        }
        public void ShowPokemonInfo()
        {
            Console.WriteLine($"Name: {Name}\nLevel: {Level}\nType: {Type}\nAbility: {AbilityName}");
        }
    }
}
