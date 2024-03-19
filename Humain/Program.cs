namespace Humain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Human human = new Human( 10, "test");
            human.Marcher();
            human.Lancer();



        }
    }
    
}
