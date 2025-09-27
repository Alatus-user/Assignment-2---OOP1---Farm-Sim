using System;
using UnityEngine;

public class Cow : Animal_Common
{

    private float milk;

    public float Milk
    {
        get { return milk; }
        private set { milk = Mathf.Max(0f, value); }
    }

    public void Init(string name, int hunger, int happiness)
    {
        base.Init(name, hunger, happiness, FoodType.Hay);
        Milk = milk;
    }

    public override void GetStatus()
    {
        base.GetStatus();
    }
    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Mohuhuhuhu");
    }

    public void Mooooooo()
    {
        AdjustHunger(-5);
        AdjustHappiness(+10);
        Debug.Log($"{Name} is sleeping...zzzzzzz");
    }

    public override void Food()
    {
        Debug.Log($"{Name} eat:Hay");
    }
    
    public override string Produce()
    {
        if (Happiness > 20)
        {
            int totalMilk = Happiness / 10;
            return $"{Name} produced Total Milk: {totalMilk} liters.";
        }
        else
        {
            return $"{Name} is not happy enough to produce milk.";
        }
    }


}
