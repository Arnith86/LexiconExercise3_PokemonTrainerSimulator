using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;

namespace LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages
{
	/// <summary>
	/// This static class is used to display messages related to Pokémon evolution.
	/// </summary>
	internal class DisplayEvolutionMessage
	{
		/// <summary>
		/// Formats and prints a message to the console indicating that a <see cref="Pokemon"/> is evolving, along with its new name and level.
		/// </summary>
		/// <param name="name">String representing the old name of the <see cref="Pokemon"/>.</param>
		/// <param name="newName">String representing the new name of the <see cref="Pokemon"/>.</param>
		/// <param name="newLevel">Int representing the new level of the <see cref="Pokemon"/>.</param>
		internal static void PrintEvolutionMessage(string name, string newName, int newLevel)
		{
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			ConsoleWritePrint.WriteLine($"{name} is evolving...Now it's {newName}! Level {newLevel}!");
			Console.ResetColor();
		}
	}
}