namespace PokemonStrategy.Models
{
    internal class BattleState
    {
        public string State { get; set; } = "Normal";
        public Pokemon AttackPokemon { get; set; }
        public Pokemon FoePokemon { get; set; }

        public BattleState(Pokemon attacker, Pokemon defender)
        {
            AttackPokemon = attacker;
            FoePokemon = defender;
        }

        public void ShowState()
        {
            Console.WriteLine("Battle state:");
            Console.WriteLine($"State: {State}");
            AttackPokemon.ShowState();
            FoePokemon.ShowState();
            Console.WriteLine();
        }
    }
}
