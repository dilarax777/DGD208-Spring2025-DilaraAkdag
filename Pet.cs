using System;
using System.Threading.Tasks;

public class Pet
{
    public string Name { get; set; }
    public PetType PetType { get; set; }
    public int Hunger { get; set; } = 50;
    public int Sleep { get; set; } = 50;
    public int Fun { get; set; } = 50;
    public bool IsAlive { get; private set; } = true;
    public PetStat Mood { get; private set; } = PetStat.Happy;

    public async Task DecreaseStatsAsync()
    {
        while (IsAlive)
        {
            await Task.Delay(5000);
            Hunger -= 1;
            Sleep -= 1;
            Fun -= 1;

            if (Hunger <= 0 || Sleep <= 0 || Fun <= 0)
            {
                IsAlive = false;
                break;
            }

            UpdateMood();
        }
    }

    private void UpdateMood()
    {
        if (Hunger < 30 || Sleep < 30 || Fun < 30)
            Mood = PetStat.Unhappy;
        if (Hunger < 10 || Sleep < 10 || Fun < 10)
            Mood = PetStat.Angry;
        if (Hunger < 5 || Sleep < 5 || Fun < 5)
            Mood = PetStat.Afraid;
        if (Hunger > 50 && Sleep > 50 && Fun > 50)
            Mood = PetStat.Happy;
    }
}