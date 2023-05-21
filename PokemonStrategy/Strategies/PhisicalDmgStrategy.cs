using PokemonStrategy.Abstractions;
using PokemonStrategy.Models;

namespace PokemonStrategy.Strategies
{
    internal class PhisicalDmgStrategy : IAttackStrategy
    {
        private readonly int value;

        public PhisicalDmgStrategy(int value)
        {
            this.value = value;
        }

        public BattleState executeAttack(BattleState battle)
        {
            var total = value - battle.FoePokemon.Stats.Defense;
            if (total > 0)
            {
                battle.FoePokemon.Stats.Life -= total;
            }
            return battle;
        }
    }
}
