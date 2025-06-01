using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;
using LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages;
using LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations.AttackMenuValidation;

namespace LexiconExercise3_PokemonTrainerSimulator.PokemonTypes
{
	internal class WaterPokemon : Pokemon
	{
		public WaterPokemon( string name, int level, List<Attack> attacks)
			: base(name, level, Type.Water, attacks)
		{
		}
	}
}
