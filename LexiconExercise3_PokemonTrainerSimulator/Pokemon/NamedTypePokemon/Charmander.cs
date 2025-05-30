using LexiconExercise3_PokemonTrainerSimulator.Pokemon.GenericTypePokemon;
using LexiconExercise3_PokemonTrainerSimulator.Utils.ConsoleAbstraction;
using LexiconExercise3_PokemonTrainerSimulator.Utils.InputValidations.AttackMenuValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon.NamedTypePokemon;

internal class Charmander : FirePokemon
{
	public Charmander(string name, int level, List<Attack> attacks)
			: base(name, level, attacks)
	{
	}
}
