using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.Utils.NameValidator
{
	/// <summary>
	/// A class that validates Pokémon names based on specific criteria.
	/// </summary>
	internal class NameValidator : INameValidator
	{
		/// <inheritdoc/>
		public bool IsNameValid(string name)
		{
			return !string.IsNullOrWhiteSpace(name) &&
				   (name.Length >= 2) &&
				   (name.Length <= 15); 
		}
	}
}
