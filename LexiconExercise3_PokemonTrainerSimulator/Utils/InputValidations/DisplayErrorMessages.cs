
using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;

namespace LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations
{
	/// <summary>
	/// This class supplies generic error messages that can be used throughout the application.
	/// </summary>
	internal class DisplayErrorMessages
	{
		private IConsoleWritePrint? _consoleWritePrint;

		public DisplayErrorMessages(IConsoleWritePrint consoleWritePrint) =>
			_consoleWritePrint = consoleWritePrint;

		/// <summary>
		/// Used to inform that input supplied was either not a number or outside the expected range.
		/// </summary>
		internal void InvalidMenuInput() =>
			DisplayErrorMessage("You supplied an invalid input! \nOnly integers within the menus range are allowed, try again!");
		
		/// <summary>
		/// Used to inform that input supplied cannot be a negative value.
		/// </summary>
		internal void InvalidInputEmpty() =>
			DisplayErrorMessage("Input cannot be empty! Please try again.");

		/// <summary>
		/// Displays the supplied error message in red text on the console.
		/// </summary>
		/// <param name="message">The string message to display.</param>
		public void DisplayErrorMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			_consoleWritePrint.WriteLine(message);
			Console.ResetColor();
		}
	}
}