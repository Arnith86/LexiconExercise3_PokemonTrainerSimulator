using LexiconExercise3_PokemonTrainerSimulator.PokemonTypes.EvolvingPokemon;
using LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages;

namespace LexiconExercise3_PokemonTrainerSimulator.PokemonTypes.NamedTypePokemon;

/// <summary>
/// Represents a Squirtle <see cref="Pokemon"/> which is a type of <see cref="WaterPokemon"/>.
/// </summary>
internal class Squirtle : WaterPokemon, IEvolvable
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

	/// <summary>
	/// Evolves the Squirtle into a Wartortle, increasing its level by 10 and changing its name.
	/// </summary>
	public void Evolve()
	{
		string newName = "Wartortle";
		int newLevel = Level + 10;

		DisplayEvolutionMessage.PrintEvolutionMessage(
			Name, newName, newLevel
		);

		Name = newName;
		Level = newLevel;
	}
}
