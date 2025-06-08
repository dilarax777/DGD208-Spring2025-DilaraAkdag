using System;
using System.Threading.Tasks;

public class Item
{
    public string Name { get; set; }
    public ItemType Type { get; set; }
    public int HungerBoost { get; set; }
    public int SleepBoost { get; set; }
    public int FunBoost { get; set; }
    public int DurationSeconds { get; set; }

    public async Task UseAsync(Pet pet)
    {
        Console.WriteLine($"Using {Name} on {pet.Name}...");
        await Task.Delay(DurationSeconds * 1000);
        pet.Hunger += HungerBoost;
        pet.Sleep += SleepBoost;
        pet.Fun += FunBoost;
    }
}