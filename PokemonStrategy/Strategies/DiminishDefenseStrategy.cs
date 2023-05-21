using PokemonStrategy.Abstractions;
using PokemonStrategy.Models;

namespace PokemonStrategy.Strategies
{
    internal class DiminishDefenseStrategy : IAttackStrategy
    {
        private readonly int value;
        private readonly PokemonStat stats;

        public DiminishDefenseStrategy(int value, PokemonStat stats)
        {
            this.value = value;
            this.stats = stats;
        }

        public BattleState executeAttack(BattleState battle)
        {
            stats.Defense -= value;
            return battle;
        }
    }
}
