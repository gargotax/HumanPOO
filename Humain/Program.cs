namespace Humain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Human personne = new Human();
            personne.Jambes = new Jambes
            {
                PiedDroit = new Pied(),
                PiedGauche = new Pied()
            };

            personne.MainGauche = new Main
            {
                MainGauche = new Main()
            };

            personne.Action();

            personne.MainDroite.Action();
        }
    }
    
}
