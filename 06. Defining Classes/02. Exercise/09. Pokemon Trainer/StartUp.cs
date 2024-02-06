using PokemonTrainer;

namespace PokemonTrainer;

public class StartUp
{
    static void Main(string[] args)
    {
        string command = string.Empty;

        List<Trainer> trainers = new List<Trainer>();

        while ((command = Console.ReadLine()) != "Tournament")
        {
            string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string trainerName = info[0];
            string pokemonName = info[1];
            string pokemonElement = info[2];
            int pokemonHealth = int.Parse(info[3]);

            Trainer currentTrainer = trainers.SingleOrDefault(t => t.Name == trainerName);

            if (currentTrainer == null)
            {
                trainers.Add(CreateTrainer(trainerName, 0, (CreatePokemon(pokemonName, pokemonElement, pokemonHealth))));
            }
            else
            {
                currentTrainer.Pokemons.Add(CreatePokemon(pokemonName, pokemonElement, pokemonHealth));
            }
        }

        while ((command = Console.ReadLine()) != "End")
        {
            foreach (Trainer trainer in trainers)
            {
                trainer.CheckPokemon(command);
            }
        }

        foreach (Trainer trainer in trainers.OrderByDescending(t => t.BadgesCount))
        {
            Console.WriteLine($"{trainer.Name} {trainer.BadgesCount} {trainer.Pokemons.Count}");
        }


       
        static Pokemon CreatePokemon(string name, string element, int health)
        {
            Pokemon pokemon = new Pokemon(name, element, health);
            return pokemon;
        }
      
        static Trainer CreateTrainer(string name, int badges, Pokemon pokemon)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            pokemons.Add(pokemon);

            Trainer trainer = new Trainer(name, badges, pokemons);
            return trainer;
        }
    }
}


