using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator;
/// <summary>
/// Represents an attack that a Pokémon can perform.
/// </summary>
internal class Attack
{
	/// <summary>
	/// The name of the attack.
	/// </summary>
	public string Name { get; private set; }

	/// <summary>
	/// The <see cref="Type"/> of the attack, which can be used to determine effectiveness against other types.
	/// </summary>
	public Type Type { get; private set; }

	/// <summary>
	/// The base power of the attack. A numeric value that represents the strength of the attack.
	/// </summary>
	public int BasePower { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Attack"/> class with the specified name, type, and base power.
	/// </summary>
	/// <param name="name">The name of the attack.</param>
	/// <param name="type">The <see cref="Type"/> of the attack.</param>
	/// <param name="basePower">The numeric value representing the base power of the attack.</param>
	public Attack(string name, Type type, int basePower)
	{
		Name = name;
		Type = type;
		BasePower = basePower;
	}

	/// <summary>
	/// Uses the attack with a specified level, returns a string describing the attacks effect.
	/// </summary>
	/// <param name="level">The Pokémon level.</param>
	/// <returns></returns>
	public string Use(int level) =>
		$"{Name} hits with a total power of {BasePower + level}!";
}
