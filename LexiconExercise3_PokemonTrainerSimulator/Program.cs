using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;
using LexiconExercise3_PokemonTrainerSimulator.Pokemon;
using LexiconExercise3_PokemonTrainerSimulator.Pokemon.NamedTypePokemon;
using LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages;

namespace LexiconExercise3_PokemonTrainerSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var flamethrower = new Attack("Flamethrower", Type.Fire, 12);
            var ember = new Attack("Ember", Type.Fire, 6);

            //TODO: HANDLE exeption
            Charmander charmander = new Charmander("Boko", 1, new List<Attack> {flamethrower, ember});

			Console.WriteLine(charmander.Attack());

			Console.WriteLine();
        }
    }
}
