namespace LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations.AttackMenuValidation
{//TODO: remove this interface if not used.

	/// <summary>
	/// This interface defines a contract for validating user input in the attack menu of a Pokémon trainer simulator.
	/// </summary>
	internal interface IAttackMenuInputValidation
	{
		/// <summary>
		/// Requests user input for selectin an attack from a menu, ensuring the input is valid.
		/// </summary>
		/// <param name="minOption">The lowest numeric option in the menu.</param>
		/// <param name="maxOption">The highest numeric option in the menu.</param>
		/// <returns>Validated string input.</returns>
		string AttackMenuInputRequest(int minOption, int maxOption);
	}
}