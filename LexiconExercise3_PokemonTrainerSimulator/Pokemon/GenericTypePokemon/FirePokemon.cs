using LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages;
using LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations.AttackMenuValidation;

namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon.GenericTypePokemon
{
	internal class FirePokemon : Pokemon
	{
		public FirePokemon(
			string name,
			int level,
			List<Attack> attacks)
			: base(name, level, Type.Fire, attacks)
		{

		}
	}
}
