﻿namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon.NamedTypePokemon;

/// <summary>
/// Represents a Pikachu <see cref="Pokemon"/> which is a type of <see cref="ElectricPokemon"/>.
/// </summary>
internal class Pikachu : ElectricPokemon
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Pikachu"/> class with the specified name, level and attacks.
	/// </summary>
	/// <param name="name">A string representing the name of the Pokémon.</param>
	/// <param name="level">An int representing the level of the Pokémon.</param>
	/// <param name="attacks">A List of <see cref="Attack"/> that the Pokémon can use.</param>
	public Pikachu(string name, int level, List<Attack> attacks)
			: base(name, level, attacks)
	{
	}
}
