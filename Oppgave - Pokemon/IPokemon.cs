namespace Oppgave___Pokemon
{
    public interface IPokemon
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public void LooseHealth(int attackDmg);
        public void Attack(IPokemon pokemon);

    }
}