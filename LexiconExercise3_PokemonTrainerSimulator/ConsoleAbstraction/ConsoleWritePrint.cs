using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.ConsoleAbstraction
{
	/// <summary>
	/// A class that abstracts console input and output operations.
	/// </summary>
	public class ConsoleWritePrint
	{
		/// <summary>
		/// Writes a message to the console with a new line at the end.
		/// </summary>
		/// <param name="message">The message to write to the console.</param>
		public void WriteLine(string message) =>
			Console.WriteLine(message);

		/// <summary>
		/// Writes a message to the console without a new line at the end.
		/// </summary>
		/// <param name="message">The message to write to the console.</param>
		public void Write(string message) =>
			Console.Write(message);


		/// <summary>
		/// Reads a line of input from the console. If the input is null, returns an empty string.
		/// </summary>
		/// <returns>Registered string, or empty string if null was registered.</returns>
		public string ReadLine()
		{
			return Console.ReadLine() ?? string.Empty;
		}
	}
}
