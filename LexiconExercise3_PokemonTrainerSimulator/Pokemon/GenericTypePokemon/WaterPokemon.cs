using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.Pokemon
{
	internal class WaterPokemon : Pokemon
	{
		public WaterPokemon(string name, int level, Type type, List<Attack> attacks) 
			: base(name, level, type, attacks)
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
