namespace LexiconExercise3_PokemonTrainerSimulator.PokemonTypes.EvolvingPokemon
{
	/// <summary>
	/// An interface representing a <see cref="Pokemon"/> that can evolve into a more powerful form.
	/// </summary>
	internal interface IEvolvable
	{
		/// <summary>
		/// Evolves the Pokémon into its next stage, if applicable.
		/// </summary>
		void Evolve();
	}
}
