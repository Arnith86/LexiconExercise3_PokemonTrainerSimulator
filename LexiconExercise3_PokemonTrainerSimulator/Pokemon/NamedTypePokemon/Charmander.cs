using LexiconExercise3_PokemonTrainerSimulator.Pokemon.GenericTypePokemon;
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
