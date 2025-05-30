namespace LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction
{//TODO : remove this interface if not used 
	public interface IConsoleWritePrint
	{
		string ReadLine();
		void Write(string message);
		void WriteLine(string message);
	}
}