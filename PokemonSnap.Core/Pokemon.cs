using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonSnap.Core
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public static List<Pokemon> GetPokedex()
        {
            List<Pokemon> pokemons = new List<Pokemon>()
            {
                new Pokemon() { Name = "Bublasaur", Description = "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon." },
                new Pokemon() { Name = "Ivysaur", Description = "There is a plant bulb on its back. When it absorbs nutrients, the bulb is said to blossom into a large flower."},
                new Pokemon() { Name = "Venusaur", Description = "By spreading the broad petals of its flower and catching the sun's rays, it fills its body with power." },
                new Pokemon() { Name = "Charmander", Description = "The flame on its tail indicates Charmander's life force. If it is healthy, the flame burns brightly." },
                new Pokemon() { Name = "Charmeleon", Description = "It lashes about with its tail to knock down its foe. It then tears up the fallen opponent with sharp claws." },
                new Pokemon() { Name = "Charizard", Description = "When expelling a blast of superhot fire, the red flame at the tip of its tail burns more intensely." },
                new Pokemon() { Name = "Squirtle", Description = "It shelters itself in its shell, then strikes back with spouts of water at every opportunity." },
                new Pokemon() { Name = "Wartortle", Description = "When tapped, this Pokémon will pull in its head, but its tail will still stick out a little bit." },
                new Pokemon() { Name = "Blastoise", Description = "It crushes its foe under its heavy body to cause fainting. In a pinch, it will withdraw inside its shell." }
            };

            return pokemons;

        }
    }

    
}
