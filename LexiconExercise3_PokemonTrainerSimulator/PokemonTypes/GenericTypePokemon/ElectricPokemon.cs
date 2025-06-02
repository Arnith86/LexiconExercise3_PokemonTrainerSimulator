namespace LexiconExercise3_PokemonTrainerSimulator.PokemonTypes
{
	internal class ElectricPokemon : Pokemon
	{
		public ElectricPokemon(string name, int level, List<Attack> attacks)
			: base(name, level, Type.Electric, attacks)
		{
		}
	}
}
