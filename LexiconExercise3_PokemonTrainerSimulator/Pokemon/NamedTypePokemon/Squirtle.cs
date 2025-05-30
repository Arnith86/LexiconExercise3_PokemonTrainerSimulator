namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon.NamedTypePokemon;

/// <summary>
/// Represents a Squirtle <see cref="Pokemon"/> which is a type of <see cref="WaterPokemon"/>.
/// </summary>
internal class Squirtle : WaterPokemon
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Squirtle"/> class with the specified name, level and attacks.
	/// </summary>
	/// <param name="name">A string representing the name of the Pokémon.</param>
	/// <param name="level">An int representing the level of the Pokémon.</param>
	/// <param name="attacks">A List of <see cref="Attack"/> that the Pokémon can use.</param>
	public Squirtle(string name, int level, List<Attack> attacks)
			: base(name, level, attacks)
	{
	}
}
