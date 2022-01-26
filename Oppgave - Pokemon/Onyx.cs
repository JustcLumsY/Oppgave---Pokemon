namespace Oppgave___Pokemon
{
    public class Onyx : IPokemon
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public Onyx(string name)
        {
            Name = name;

        }
        public void LooseHealth(int attackDmg)
        {
            
        }

        public void Attack(IPokemon pokemon)
        {
            throw new System.NotImplementedException();
        }
    }
}