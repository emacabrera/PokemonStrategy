using PokemonStrategy.Abstractions;
using PokemonStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStrategy.Strategies
{
    internal class RainStrategy : IAttackStrategy
    {
        public BattleState executeAttack(BattleState battle)
        {
            battle.State = "Raining";
            return battle;
        }
    }
}
