using System.Collections.Generic;

public static class ItemDatabase
{
    public static List<Item> AllItems => new List<Item>
    {
        new Item { Name = "Red Ribbon", Type = ItemType.RedRibbon, HungerBoost = 10, SleepBoost = 5, FunBoost = 15, DurationSeconds = 2 },
        new Item { Name = "Feather Aura", Type = ItemType.FeatherAura, HungerBoost = 5, SleepBoost = 15, FunBoost = 10, DurationSeconds = 2 },
        new Item { Name = "Angel Wings", Type = ItemType.AngelWings, HungerBoost = 15, SleepBoost = 10, FunBoost = 5, DurationSeconds = 2 },
        new Item { Name = "Unicorn Outfit", Type = ItemType.UnicornOutfit, HungerBoost = 20, SleepBoost = 20, FunBoost = 20, DurationSeconds = 3 },
    };
}