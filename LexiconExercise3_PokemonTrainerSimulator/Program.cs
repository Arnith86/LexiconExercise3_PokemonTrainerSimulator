namespace LexiconExercise3_PokemonTrainerSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var flamethrower = new Attack("Flamethrower", Type.Fire, 12);
            var ember = new Attack("Ember", Type.Fire, 6);

			Console.WriteLine(flamethrower.Use(10));
            Console.WriteLine(ember.Use(5));
        }
    }
}
