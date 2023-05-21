using PokemonStrategy.Models;

namespace PokemonStrategy.Abstractions
{
    internal interface IAttackStrategy
    {
        BattleState executeAttack(BattleState battle);
    }
}
