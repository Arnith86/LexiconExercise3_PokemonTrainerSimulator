﻿using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations.AttackMenuValidation
{
	/// <summary>
	/// This class validates user input for the attack menu, ensuring that the input is a valid integer within a specified range.
	/// </summary>
	internal class AttackMenuInputValidation
	{
		private readonly DisplayErrorMessages _displayErrorMessages;

		/// <summary>
		/// Initializes a new instance of the <see cref="AttackMenuInputValidation"/> class with a specified <see cref="DisplayErrorMessages"/> instance.
		/// </summary>
		/// <param name="displayErrorMessages">Formats error messages, and contains a couple of generic error messages.</param>
		public AttackMenuInputValidation(DisplayErrorMessages displayErrorMessages)
		{
			_displayErrorMessages = displayErrorMessages;
		}

		/// <summary>
		/// Validates the input for the attack menu.
		/// </summary>
		/// <param name="input">User input in string format.</param>
		/// <param name="minOption">The lowest numeric option in the menu.</param>
		/// <param name="maxOption">The highest numeric option in the menu.</param>
		/// <returns>True, if input is valid, False, it is not.</returns>
		public bool IsAttackMenuInputValid(string input, int minOption, int maxOption)
		{
			if ( string.IsNullOrWhiteSpace(input) )
			{
				_displayErrorMessages.InvalidInputEmpty();
				return false;
			}
			else if (
				!int.TryParse(input, out int intInput) 
				|| (intInput < minOption) 
				|| (intInput > maxOption)) 
			{
				_displayErrorMessages.InvalidMenuInput();
				return false;
			}

			return true;
		}
	}
}
