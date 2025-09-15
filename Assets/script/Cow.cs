using System;
using UnityEngine;

public class Cow
{
    private string name;
    private int hunger;
    private int happiness;
    private float milk;

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
                Debug.Log("Invalid name, setting default name = Cow");
                name = "Otis";
            }
        }
    }

    public int Hunger
    {
        get { return hunger; }
        private set
        {
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
        private set
        {
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

    public float Milk
    {
        get { return milk; }
        private set { milk = Mathf.Max(0f, value); }
    }

    public Cow(string name, int hunger, int happiness, float milk)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
        Milk = milk;
    }

    public void AdjustHunger(int i)
    {
        Hunger = Hunger + i;
        Debug.Log($"{Name} Hunger = {Hunger}");
    }

    public void AdjustHappiness(int amount)
    {
        Happiness = Happiness + amount;
        Debug.Log($"{Name} Happiness = {Happiness}");
    }

    public void Feed(string food)
    {
        AdjustHunger(+10);
        AdjustHappiness(+5);
        Debug.Log($"{Name} eat {food}.");
    }

    public void Sleep()
    {
        AdjustHunger(-5);
        AdjustHappiness(+10);
        Debug.Log($"{Name} slept.");
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says: Moo!");
    }

    public void GetStatus()
    {
        Debug.Log($"[Cow Status] Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}, Milk: {Milk}");
    }
}
