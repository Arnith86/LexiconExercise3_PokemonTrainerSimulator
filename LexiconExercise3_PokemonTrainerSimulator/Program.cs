using LexiconExercise3_PokemonTrainerSimulator.PokemonTypes;
using LexiconExercise3_PokemonTrainerSimulator.PokemonTypes.EvolvingPokemon;
using LexiconExercise3_PokemonTrainerSimulator.PokemonTypes.NamedTypePokemon;
using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;

namespace LexiconExercise3_PokemonTrainerSimulator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Pokemon> pokemons = new List<Pokemon>();

			Charmander charmander;
			Squirtle squirtle;
			Pikachu pikachu;
			Tangela tangela;

			// Initialize fire type attacks
			var flamethrower = new Attack("Flamethrower", Type.Fire, 12);
			var ember = new Attack("Ember", Type.Fire, 6);

			// Initialize water type attacks
			var bubble = new Attack("Bubble", Type.Water, 8);
			var waterGun = new Attack("Water Gun", Type.Water, 11);


			// Initialize electric type attacks
			var thunderShock = new Attack("Thunder Shock", Type.Electric, 7);
			var thunderBolt = new Attack("Thunder Bolt", Type.Electric, 14);


			try
			{
				pokemons.Add( new Charmander("Charmander", 1, new List<Attack> { ember, flamethrower }));
				pokemons.Add( new Squirtle("Squirtle", 1, new List<Attack> { bubble, waterGun }));
				pokemons.Add(new Pikachu("Pikachu", 1, new List<Attack> { thunderShock, thunderBolt }));
				pokemons.Add(new Tangela("Tangela", 1, new List<Attack> { bubble, waterGun }));
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
				return;
			}
			catch (ArgumentNullException ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
				return;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"An unexpected error occurred: {ex.Message}");
				return;
			}

			List<WaterPokemon> waterPokemons = new List<WaterPokemon>();


			foreach (var pokemon in pokemons)
			{
				ConsoleWritePrint.WriteLine($"{pokemon.Name} performs a random attack: ");
				pokemon.RandomAttack();
				ConsoleWritePrint.WriteLine("");

				pokemon.Attack();
				ConsoleWritePrint.WriteLine("");

				pokemon.RaiseLevel();
				ConsoleWritePrint.WriteLine("");

				if (pokemon is IEvolvable isEvolvable)
					isEvolvable.Evolve();
				else
					ConsoleWritePrint.WriteLine($"{pokemon.Name} does not have the ability to evolve.");
				ConsoleWritePrint.WriteLine("");
			}

			Console.WriteLine();
		}
	}
}
