using System.Text.Json;

namespace PokemonStrategy.Models
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public PokemonStat Stats { get; set; }

        public Pokemon(string name, PokemonStat stats)
        {
            Name = name;
            Stats = stats;
        }

        public void ShowState()
        {
            Console.WriteLine(Name);
            Console.WriteLine(JsonSerializer.Serialize(Stats));
        }
    }
}
