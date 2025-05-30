namespace LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction
{
	public interface IConsoleWritePrint
	{
		string ReadLine();
		void Write(string message);
		void WriteLine(string message);
	}
}