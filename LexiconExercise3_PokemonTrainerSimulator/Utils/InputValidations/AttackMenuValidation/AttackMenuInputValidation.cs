using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;
using LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations.AttackMenuValidation;

/// <summary>
/// This class validates user input for the attack menu, ensuring that the input is a valid integer within a specified range.
/// </summary>
internal static class AttackMenuInputValidation // : IAttackMenuInputValidation
{
	/// <summary>
	/// Requests user input for selectin an attack from a menu, ensuring the input is valid.
	/// </summary>
	/// <param name="minOption">The lowest numeric option in the menu.</param>
	/// <param name="maxOption">The highest numeric option in the menu.</param>
	/// <returns>Validated string input.</returns>
	public static string AttackMenuInputRequest(int minOption, int maxOption)
	{
		bool isValidInput = false;
		string input = string.Empty;

		do
		{
			ConsoleWritePrint.Write("Please select an attack by entering the corresponding number: ");

			if (IsAttackMenuInputValid(
					input = ConsoleWritePrint.ReadLine(), 
					minOption, 
					maxOption)
			)
				isValidInput = true;

		} while (!isValidInput);

		return input;
	}


	/// <summary>
	/// Validates the input for the attack menu.
	/// </summary>
	/// <param name="input">User input in string format.</param>
	/// <param name="minOption">The lowest numeric option in the menu.</param>
	/// <param name="maxOption">The highest numeric option in the menu.</param>
	/// <returns>True, if input is valid, False, it is not.</returns>
	private static bool IsAttackMenuInputValid(string input, int minOption, int maxOption)
	{
		if (string.IsNullOrWhiteSpace(input))
		{
			DisplayErrorMessages.InvalidInputEmpty();
			return false;
		}
		else if (
			!int.TryParse(input, out int intInput)
			|| (intInput < minOption)
			|| (intInput > maxOption))
		{
			DisplayErrorMessages.InvalidMenuInput();
			return false;
		}

		return true;
	}
}
