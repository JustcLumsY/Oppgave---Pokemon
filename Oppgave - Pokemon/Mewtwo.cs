using System;

namespace Oppgave___Pokemon
{
    public class Mewtwo : IPokemon
    {
        public int Health { get; set;}
        public string Name { get; set; }

        public Mewtwo(string name)
        {
            Name = name;
        }

        public void LooseHealth(int attackDmg)
        {
            
        }

        public void Attack(IPokemon pokemon)
        {
            Console.WriteLine("Mewtwo bruker attack: ");
            Powerpunch(pokemon);
        }

        public Mewtwo()
        {
            Health = 125;
        }

        public void Powerpunch(IPokemon pokemon)
        {
            Console.WriteLine("PowerPunch");
            pokemon.LooseHealth(10);
        }
    }
}