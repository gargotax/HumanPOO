namespace Humain
{
    public class Human
    {
        public Bras BrasGauche { get; }
        public Bras BrasDroit { get; }
        public Jambes JambeGauche { get; }
        public Jambes JambeDroite { get; }
        public int Age { get; }
        public string Nom { get; }

        public Human(Bras brasGauche, Bras brasDroit, Jambes jambeGauche, Jambes jambeDroite, int age, string nom)
        {
            BrasGauche = brasGauche;
            BrasDroit = brasDroit;
            JambeGauche = jambeGauche;
            JambeDroite = jambeDroite;
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