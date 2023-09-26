using QueryBuilder.Model;

namespace QueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize your QueryBuilder instance.
            var queryBuilder = new QueryBuilder("path_to_database.db");

            // Delete all records of a specific type (e.g., Pokemon).
            queryBuilder.DeleteAll<Pokemon>();

            // Create a collection of Pokemon objects and insert them into the database.
            List<Pokemon> pokemonCollection = new List<Pokemon>
            {
                // Add Pokemon objects to the collection.
            };

            foreach (var pokemon in pokemonCollection)
            {
                queryBuilder.Create(pokemon);
            }

            // Create a single Pokemon object and insert it into the database.
            var singlePokemon = new Pokemon
            {
                // Initialize Pokemon properties.
            };
            queryBuilder.Create(singlePokemon);

            // Repeat the above steps for BannedGame objects if needed.

            // Add Console messages for visual confirmation.
            Console.WriteLine("Database operations completed successfully.");
        }
    }
}