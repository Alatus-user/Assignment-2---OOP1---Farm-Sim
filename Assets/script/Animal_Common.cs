using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal_Common : MonoBehaviour
{
    private string name;
    private int hunger;
    private int happiness;
    public string Sound;
    public string food;
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

    public virtual void Init(string name, int hunger, int happiness)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
    }



    //method
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

    public virtual void MakeSound()
    {
        Debug.Log($"{Name} says: {Sound}");
    }

    public void Feed(int feeded)
    {
        AdjustHunger(+10);
        AdjustHappiness(+10);
      
    }

    public virtual void Food()
    {
        Debug.Log($"{Name} eat: {food}!");
    }


    public virtual void GetStatus()
    {
        Debug.Log($"[Animal Status] Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}");
       
    }
}
