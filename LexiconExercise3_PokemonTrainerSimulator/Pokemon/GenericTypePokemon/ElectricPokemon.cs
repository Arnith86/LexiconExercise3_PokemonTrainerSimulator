using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;
using LexiconExercise3_PokemonTrainerSimulator.Utils.DisplayMessages;
using LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations.AttackMenuValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon
{
	internal class ElectricPokemon : Pokemon
	{
		public ElectricPokemon(string name, int level, List<Attack> attacks)
			: base(name, level, Type.Electric, attacks)
		{
		}
	}
}
