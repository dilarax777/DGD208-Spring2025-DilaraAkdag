using System;

namespace InteractivePetSimulator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Interactive Pet Simulator";

            try
            {
                Game game = new Game();
                game.Run(); // Game.cs içinde oyun akışını başlatan metot
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}