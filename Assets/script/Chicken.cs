using System;
using UnityEngine;

public class Chicken
{
    private string name;
    private int hunger;
    private int happiness;
    private int eggs;

    public string Name
    {
        get { return name; }
        private set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                Debug.Log("Invalid name, setting default name = Chicken");
                name = "CluckeR";
            }
        }
    }

    public int Hunger
    {
        get { return hunger; }
        private set {
            if (value < 0)
            {
                hunger = 0;
            }
            else if (value > 100)
            {
                hunger = 100;
            }
            else
            {
                hunger = value;
            }
        }
    }

    public int Happiness
    {
        get { return happiness; }
        private set {
            if (value < 0)
            {
                happiness = 0;
            }
            else if (value > 100)
            {
                happiness = 100;
            }
            else
            {
                happiness = value;
            }
        }
    }

    public int Eggs
    {
        get { return eggs; }
        private set {
            if (value < 0)
            {
                eggs = 0;
            }
            else
            {
                eggs = value;
            }
        }
    }

    public Chicken(string name, int hunger, int happiness, int eggs)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
        Eggs = eggs;
    }

    public void AdjustHunger(int i)
    {
        Hunger = Hunger + i;
        Debug.Log($"{Name} Hunger: {Hunger}");
    }

    public void AdjustHappiness(int i)
    {
        Happiness = Happiness + i;
        Debug.Log($"{Name} Happiness: {Happiness}");
    }

    public void Feed(string food)
    {
        AdjustHunger(+10);
        AdjustHappiness(+10);
        Debug.Log($"{Name} eat {food}!");
    }

    public void Sleep()
    {
        AdjustHunger(-5);
        AdjustHappiness(+10);
        Debug.Log($"{Name} is sleeping...zzzzzzz");
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says: Cluck!");
    }

    public void GetStatus()
    {
        Debug.Log($"[Chicken Status] Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}, Eggs: {Eggs}");
    }
}
