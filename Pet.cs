using System;

namespace InteractivePetSimulator
{
    public class Pet
    {
        public string Name { get; private set; }
        public PetType Type { get; private set; }

        public int Hunger { get; private set; } = 50;
        public int Sleep { get; private set; } = 50;
        public int Fun { get; private set; } = 50;

        public bool IsAlive => Hunger > 0 && Sleep > 0 && Fun > 0;

        public Pet(string name, PetType type)
        {
            Name = name;
            Type = type;
        }

        public void UpdateStats(int hungerDelta, int sleepDelta, int funDelta)
        {
            Hunger = Math.Clamp(Hunger + hungerDelta, 0, 100);
            Sleep = Math.Clamp(Sleep + sleepDelta, 0, 100);
            Fun = Math.Clamp(Fun + funDelta, 0, 100);
        }

        public void Tick() // zaman geçtikçe statüler azalsın
        {
            UpdateStats(-1, -1, -1);
        }
    }
}