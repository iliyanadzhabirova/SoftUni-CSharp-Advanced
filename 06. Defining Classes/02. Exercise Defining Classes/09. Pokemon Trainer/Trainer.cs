using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PokemonTrainer;

public class Trainer
{
    public string Name { get; set; }
    public int BadgesCount { get; set; }
    public List<Pokemon> Pokemons { get; set; }

    public Trainer(string name, int badges, List<Pokemon> pokemons)
    {
        Name = name;
        BadgesCount = badges;
        Pokemons = pokemons;
    }

    public void CheckPokemon(string element)
    {
        if (Pokemons.Any(p => p.Element == element))
        {
            BadgesCount++;
        }
        else
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                Pokemons[i].Health -= 10;

                if (Pokemons[i].Health <= 0)
                {
                    Pokemons.Remove(Pokemons[i]);
                    i--;
                }
            }
        }
    }
}