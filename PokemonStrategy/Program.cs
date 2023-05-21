using PokemonStrategy.Abstractions;
using PokemonStrategy.Models;
using PokemonStrategy.Strategies;

var attacker = new Pokemon("Pikachu", new PokemonStat
{
    Attack = 20,
    Defense = 10,
    Life = 75,
});

var defender = new Pokemon("Onix", new PokemonStat
{
    Attack = 35,
    Defense = 15,
    Life = 100,
});

var battle = new BattleState(attacker, defender);
battle.ShowState();

IAttackStrategy attackStrategy = new RainStrategy();
// no es la mejor manera de hacerlo para saber a quien se le aplica el ataque
IAttackStrategy foeStrategy = new DiminishDefenseStrategy(5, attacker.Stats);
ComputeTurn(battle, attackStrategy, foeStrategy);

Console.ReadLine();

static void ComputeTurn(BattleState state, IAttackStrategy myAttack, IAttackStrategy foeAttack)
{
    state = myAttack.executeAttack(state);
    state = foeAttack.executeAttack(state);
    state.ShowState();
}