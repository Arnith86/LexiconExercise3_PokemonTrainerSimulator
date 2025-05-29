using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;


namespace LexiconExercise3_PokemonTrainerSimulator
{
	internal abstract class Pokemon
	{
		private readonly ConsoleWritePrint _consoleWritePrint;
		private string _name;

		public string Name 
		{ 
			get => _name;
			set => _name = ValidateNewName();
		}

		public Pokemon(ConsoleWritePrint consoleWritePrint)
		{
			_consoleWritePrint = consoleWritePrint;
		}

		private string ValidateNewName()
		{
			string pokemonName = _consoleWritePrint.ReadLine();

			return pokemonName;
		}
	}
}
