namespace LexiconExercise3_PokemonTrainerSimulator.PokemonTypes.GenericTypePokemon
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
