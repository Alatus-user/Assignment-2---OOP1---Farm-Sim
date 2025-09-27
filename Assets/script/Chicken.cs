using System;
using UnityEngine;

public class Chicken : Animal_Common
{
    private int eggs;

    public int Eggs
    {
        get { return eggs; }
        private set
        {
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

    public void Init(string name, int hunger, int happiness)
    {
        base.Init(name, hunger, happiness, FoodType.Grain);

        Eggs = eggs;
    }



    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Cluck Cluck");
    }

    public override void Food()
    {
        Debug.Log($"{Name} eat: Grain!");
    }

    public void Sleep()
    {
        AdjustHunger(-5);
        AdjustHappiness(+10);
        Debug.Log($"{Name} is sleeping...zzzzzzz");
    }

    public override void GetStatus()
    {
        base.GetStatus();
    }
    
    public override string Produce()
    {
        if (Happiness <= 20)
        {
            return $"{Name} is too sad, no eggs produced.";
        }
        else if (Happiness >= 51 && Happiness <= 79)
        {
            return $"{Name} laid 2 eggs.";
        }
        else // Happiness >= 80
        {
            return $"{Name} laid 3 eggs!";
        }
    }



}
