namespace Humain
{
    public class Human
    {
        public Bras Bras{ get; }
        public Jambes Jambes { get; }
        public int Age { get; }
        public string Nom { get; }

        public Human(int age, string nom)
        {
            Bras bras = this.Bras;
            Jambes jambes = this.Jambes;
            Age = age;
            Nom = nom;
        }

        public void Marcher()
        {
            Console.WriteLine("l'humain marche");
        }

        public void Lancer()
        {
            Console.WriteLine("l'humain lance qqc");
        }


    }
}