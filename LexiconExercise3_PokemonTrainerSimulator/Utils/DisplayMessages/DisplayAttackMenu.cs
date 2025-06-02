using LexiconExercise3_PokemonTrainerSimulator.PokemonTypes;
using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;

namespace LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages;

/// <summary>
/// This class is responsible for displaying the available attacks in the attack menu.
/// </summary>
internal static class DisplayAttackMenu
{
	/// <summary>
	/// Displays the list of attacks available for a Pokémon.
	/// </summary>
	/// <param name="attacks">A list of <see cref="Attack"/>, available to the Pokémon.</param>
	/// <param name="consoleWritePrint">A service that abstracts away console input and output.</param>
	public static void DisplayAttacks(List<Attack> attacks)
	{
		for (int i = 0; i < attacks.Count; i++)
			ConsoleWritePrint.WriteLine($"{i + 1} {attacks[i].Name}");
	}
}
