namespace Humain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Human human = new Human(new Bras(), new Bras(), new Jambes(), new Jambes(), 10, "test");
            
            human.Marcher();
            human.Lancer();


        }
    }
    
}
