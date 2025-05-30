namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon
{
	/// <summary>
	/// An interface representing a <see cref="Pokemon"/> that can evolve into a more powerful form.
	/// </summary>
	internal interface IEvolvable
	{
		/// <summary>
		/// Evolves the pokemon into its next stage, if applicable.
		/// </summary>
		void Evolve();
	}
}
