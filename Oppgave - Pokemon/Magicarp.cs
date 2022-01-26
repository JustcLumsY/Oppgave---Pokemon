using System;

namespace Oppgave___Pokemon
{
    public class Magicarp : IPokemon
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public bool IsUsless { get; set; }

        public Magicarp(string name)
        {
            Name = name;
            Health = 25;
           
        }
        public void Splash()
        {

        }

        public void LooseHealth(int attackDmg)
        {
           Health -= attackDmg;
           Console.WriteLine(Health);
        }

        public void Attack(IPokemon pokemon)
        {
            Splash();
        }
    }
}