using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon.GenericTypePokemon
{
	internal class FirePokemon : Pokemon
	{

		public FirePokemon(string name, int level, List<Attack> attacks) 
			: base(name, level, Type.Fire, attacks)
		{

		}

		/// <summary>
		/// Basic version of the Attack method. Simply uses the first attack from the Attacks list.
		/// </summary>
		/// <returns>A string representing the action of attacking.</returns>
		public override string Attack() =>
			Attacks.FirstOrDefault()
				.Use(Level);
	}
}
