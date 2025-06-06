﻿using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;
using LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages;
using LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations.AttackMenuValidation;


namespace LexiconExercise3_PokemonTrainerSimulator.PokemonTypes;

/// <summary>
/// An abstract base class representing a Pokémon in the Pokémon training simulator.
/// </summary>
internal abstract class Pokemon
{
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
	/// A list of attacks that the Pokémon knows and can performed. The property is set during construction and can be modified later.
	/// </summary>
	public List<Attack> Attacks
	{
		get => _attacks;
		protected set => _attacks = value;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Pokemon"/> class with the specified name, level, type, and attacks.
	/// </summary>
	/// <param name="name">The name of the Pokémon.</param>
	/// <param name="level">The level of the Pokémon.</param>
	/// <param name="type">The <see cref="Type"/> of the Pokémon.</param>
	/// <param name="attacks">A list of <see cref="Attack"/> that the Pokémon knows. </param>
	/// <param name="consoleWritePrint">Abstraction for console input and output.</param>
	/// <param name="attackMenuInputValidation">Service for validating attack menu inputs.</param>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="attacks"/>, <paramref name="consoleWritePrint"/> or <paramref name="attackMenuInputValidation"/> is <c>null</c>.
	/// </exception>
	public Pokemon(
		string name,
		int level,
		Type type,
		List<Attack> attacks)
	{
		Name = name; // Validated by the Property setter.
		Level = level; // Validated by the Property setter.
		_type = type;
		Attacks = attacks ?? throw new ArgumentNullException("Attacks cannot be null.");
	}

	/// <summary>
	/// Initiates an attack by displaying the attack menu and allowing the user to choose an attack.
	/// The attack is displayed in the console.
	/// </summary>
	public void Attack()
	{
		DisplayAttackMenu.DisplayAttacks(Attacks);
		Attack attack = ChoseAttack();

		ConsoleWritePrint.WriteLine(attack.Use(Level));
	}

	private Attack ChoseAttack()
	{
		int menuOption = int.Parse(
			AttackMenuInputValidation.AttackMenuInputRequest(1, Attacks.Count)
		);

		// -1 to convert to 0 start index.
		return Attacks[menuOption - 1];
	}

	/// <summary>
	/// Randomly selects an attack from the Pokémon list of attacks and invokes it.
	/// The attack is displayed in the console.
	/// </summary>
	public void RandomAttack()
	{
		// Picks a random attack from the list of attacks and invokes its .Use-method.
		int randomIndex = new Random().Next(0, Attacks.Count);

		ConsoleWritePrint.WriteLine(
			Attacks[randomIndex].Use(Level)
		);
	}


	/// <summary>
	/// Raises the level of the Pokémon by one and prints a message to the console announcing the level up.
	/// </summary>
	public void RaiseLevel()
	{
		Level++;
		ConsoleWritePrint.WriteLine($"{Name} leveled up to {Level}!");
	}
}
