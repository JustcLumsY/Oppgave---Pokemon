using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Oppgave___Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var onyx = new Onyx("Onyx");
            var diglett = new Diglett("Diglett");
            var mewtwo = new Mewtwo("MewTwo");
            var magicarp = new Magicarp("Magicarp");

            List<IPokemon> wildPokemons = new List<IPokemon>();

            //wildPokemons.Add(onyx);
            //wildPokemons.Add(diglett);
            wildPokemons.Add(mewtwo);
            wildPokemons.Add(mewtwo);
            //wildPokemons.Add(magicarp);

            //Console.WriteLine(wildPokemon.Count);
            while (magicarp.Health > 0)
            {
                var wildPokemon = GetWildPokemon(wildPokemons);
                Console.WriteLine(wildPokemon.Name);
                Thread.Sleep(1000);
                wildPokemon.Attack(magicarp);
            }
        }

            public static IPokemon GetWildPokemon(List<IPokemon> pokemons)
            {
                var rnd = new Random();
                var index = rnd.Next(0, pokemons.Count);

                return pokemons[index];
            } 
    }
}
