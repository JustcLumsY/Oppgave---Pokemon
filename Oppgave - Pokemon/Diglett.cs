namespace Oppgave___Pokemon
{
    public class Diglett : IPokemon
    {
        public int Health { get; set;}
        public string Name { get; set; }

        public Diglett(string name)
        {
            Name = name;
        }
        public void LooseHealth(int attackDmg)
        {
            throw new System.NotImplementedException();
        }

        public void Attack(IPokemon pokemon)
        {
            throw new System.NotImplementedException();
        }
    }
}