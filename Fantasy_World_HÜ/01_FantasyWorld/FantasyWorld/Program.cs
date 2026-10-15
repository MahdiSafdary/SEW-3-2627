namespace FantasyWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizard w = new Wizard("Merlin");
            Dragon d = new Dragon("Ouroborus");
            Butterfly b = new Butterfly();
            Coin c = new Coin();

            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();

                w.Move();
                d.Move();
                b.Move();

                w.Show();
                d.Show();
                c.Show();
                b.Show();
            }
        }
    }
}
