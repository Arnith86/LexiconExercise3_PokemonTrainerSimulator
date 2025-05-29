using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_PokemonTrainerSimulator.Utils.NameValidator
{
	/// <summary>
	/// Interface for validating names.
	/// </summary>
	internal interface INameValidator
	{
		/// <summary>
		/// Checks if the provided name is valid.
		/// </summary>
		/// <param name="name">The name to validate.</param>
		/// <returns>Boolean indicating if the name was valid.</returns>
		public bool IsNameValid(string name);
	}
}
