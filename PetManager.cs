using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class PetManager
{
    private readonly List<Pet> pets = new();

    public void AdoptPet()
    {
        var petTypes = Enum.GetValues(typeof(PetType)).Cast<PetType>().ToList();
        var menu = new Menu<PetType>("Select Pet Type", petTypes, pt => pt.ToString());
        PetType selectedType = menu.ShowAndGetSelection();
        if (!Enum.IsDefined(typeof(PetType), selectedType)) return;

        Console.Write("Enter a name for your pet: ");
        string name = Console.ReadLine();

        var pet = new Pet { Name = name, PetType = selectedType };
        pets.Add(pet);

        _ = pet.DecreaseStatsAsync();
        Console.WriteLine($"{name} the {selectedType} has been adopted!");
        Console.ReadKey();
    }

    public async Task CareForPetAsync()
    {
        if (!pets.Any())
        {
            Console.WriteLine("No pets to care for.\n");
            Console.ReadKey();
            return;
        }

        var menu = new Menu<Pet>("Choose a Pet", pets, p => p.Name);
        Pet selectedPet = menu.ShowAndGetSelection();
        if (selectedPet == null) return;

        var itemMenu = new Menu<Item>("Choose an Item", ItemDatabase.AllItems, i => i.Name);
        Item selectedItem = itemMenu.ShowAndGetSelection();
        if (selectedItem == null) return;

        await selectedItem.UseAsync(selectedPet);
        Console.ReadKey();
    }

    public void ShowStatuses()
    {
        Console.Clear();
        foreach (var pet in pets.ToList())
        {
            if (!pet.IsAlive)
            {
                Console.WriteLine($"{pet.Name} has died.");
                pets.Remove(pet);
                continue;
            }

            Console.WriteLine($"{pet.Name} ({pet.PetType}) - Hunger: {pet.Hunger}, Sleep: {pet.Sleep}, Fun: {pet.Fun}, Mood: {pet.Mood}");
        }

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}
