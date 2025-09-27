using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : Animal_Common
{

    public void Init(string name, int hunger, int happiness)
    {
        base.Init(name, hunger, happiness, FoodType.Oat);

    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Oink Oink");
    }

    public override void GetStatus()
    {
        base.GetStatus();
    }
    
    public override string Produce()
    {
        if (Happiness <= 20)
        {
            return $"{Name} is too sad, no Truffle produced.";
        }
        else if (Happiness >= 21 && Happiness <= 59)
        {
            return $"{Name} found 2 Truffle.";
        }
        else // Happiness >= 60
        {
            return $"{Name} found 3 Truffle!";
        }
    }
} 
        


    

