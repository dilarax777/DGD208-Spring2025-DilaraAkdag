using System;
using System.Threading.Tasks;

public class Game
{
    private readonly PetManager petManager = new();

    public async Task RunAsync()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("==== Interactive Pet Simulator ====");
            Console.WriteLine("Project by: Dilara - 195040065\n");
            Console.WriteLine("1. Adopt a Pet");
            Console.WriteLine("2. Care for a Pet");
            Console.WriteLine("3. Show Pet Statuses");
            Console.WriteLine("4. Exit\n");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    petManager.AdoptPet();
                    break;
                case "2":
                    await petManager.CareForPetAsync();
                    break;
                case "3":
                    petManager.ShowStatuses();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}