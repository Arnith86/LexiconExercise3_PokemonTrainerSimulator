using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;
using LexiconExercise3_PokemonTrainerSimulator.Utils.NameValidator;


namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon;

/// <summary>
/// An abstract base class representing a Pokémon in the Pokémon training simulator.
/// </summary>
internal abstract class Pokemon
{
	private readonly ConsoleWritePrint _consoleWritePrint;
	private string _name;
	private int _level;
	private readonly Type _type;
	private List<Attack> _attacks;

	/// <summary>
	/// The name of the Pokémon. This property must be set to a non-empty string between 2 and 15 characters long.
	/// </summary>
	public string Name 
	{ 
		get => _name;
		set
		{
			// Validates the name 
			if (string.IsNullOrWhiteSpace(value))
				throw new ArgumentException("Name cannot be null or whitespace.");
			else if ((value.Length < 2) || (value.Length > 15))
				throw new ArgumentOutOfRangeException("Name must be between 2 and 15 characters long.");
			else 
				_name = value;
		} 
	}

	/// <summary>
	/// The level of the Pokémon. This property must be set to a value of at least 1.
	/// </summary>
	public int Level
	{
		get => _level;
		set
		{
			if (value < 1)
				throw new ArgumentOutOfRangeException("Level must be at least 1.");
			else
				_level = value;
		}
	}

	/// <summary>
	/// The type of the Pokémon. This property is set during construction and cannot be changed later.
	/// </summary>
	public Type Type => _type;


	/// <summary>
	/// A list of attacks that the Pokémon knows and can performe. The property is set during construction and can be modified later.
	/// </summary>
	public List<Attack> Attacks
	{
		get => _attacks;
		protected set
		{
			_attacks = value;
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Pokemon"/> class with the specified name, level, type, and attacks.
	/// </summary>
	/// <param name="name">The name of the Pokémon.</param>
	/// <param name="level">The level of the Pokémon.</param>
	/// <param name="type">The <see cref="Type"/> of the Pokémon.</param>
	/// <param name="attacks">A list of <see cref="Attack"/> that the Pokémon knows. </param>
	/// <param name="consoleWritePrint">Console abstraction.</param>
	/// <exception cref="ArgumentNullException">"Attacks cannot be null."</exception>
	public Pokemon( 
		string name, 
		int level,
		Type type,
		List<Attack> attacks, 
		ConsoleWritePrint consoleWritePrint)
	{
		Name = name; // Validated by the Property setter.
		Level = level; // Validated by the Property setter.
		_type = type;
		Attacks = attacks ?? throw new ArgumentNullException("Attacks cannot be null.");
		_consoleWritePrint = consoleWritePrint;
	}

	/// <summary>
	/// Abstract method that must be implemented by derived classes to perform an attack.
	/// </summary>
	/// <returns>Pokémon performs an attack.</returns>
	public abstract string Attack();


	/// <summary>
	/// Raises the level of the Pokémon by one and prints a message to the console announcing the level up.
	/// </summary>
	public void RaiseLevel()
	{
		Level++;
		_consoleWritePrint.WriteLine($"{Name} leveled up to {Level}!");
	}
}
