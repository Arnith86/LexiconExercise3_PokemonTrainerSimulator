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

		/// <summary>
		/// Advanced version of the Attack method. .
		/// </summary>
		/// <returns>A string representing the action of attacking.</returns>
		public override string Attack()
		{
			DisplayAttackMenu.DisplayAttacks(Attacks);
			Attack attack = ChoseAttack();

			return attack.Use(Level);
		}

		private Attack ChoseAttack()
		{
			int menuOption = int.Parse(
				AttackMenuInputValidation.AttackMenuInputRequest(1, Attacks.Count)
			);
			return Attacks[menuOption];
		}

		///// <summary>
		///// Basic version of the Attack method. Simply uses the first attack from the Attacks list.
		///// </summary>
		///// <returns>A string representing the action of attacking.</returns>
		//public override string Attack() => 
		//	Attacks.FirstOrDefault()
		//		.Use(Level);
	}
}
