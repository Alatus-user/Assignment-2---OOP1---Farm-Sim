using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public enum FoodType
    {
        Hay,  // 0 วัวชอบ
        Grain, // 1 ไก่ชอบ
        Oat,  // 2 หมูชอบ
        RottenFood,  // 3  ไม่ชอบ 
        AnimalFood, //4   พอกินได้

    }

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

    public FoodType FavoriteFood;

    public virtual void Init(string name, int hunger, int happiness, FoodType favFood)
    {
        Name = name;
        Hunger = 50;
        Happiness = 50;
        FavoriteFood = favFood;

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

    public void Feed(FoodType foodType, int amount)
    {
        if (foodType == FavoriteFood)
        {
            AdjustHunger(-amount);
            AdjustHappiness(+15);
            Debug.Log($"{Name} is happy to eat {foodType}!");
        }
        else if (foodType == FoodType.RottenFood)
        {
            AdjustHunger(+amount);
            AdjustHappiness(-20);
            Debug.Log($"{Name} is sad to eat {foodType}.");
        }
        else if (foodType == FoodType.AnimalFood)
        {
            AdjustHunger(-amount);
            AdjustHappiness(+5);
            Debug.Log($"{Name} is okay to eat {foodType}.");
        }

    }





    public virtual void Food()
    {
        Debug.Log($"{Name} eat: {food}!");
    }


    public virtual void GetStatus()
    {
        Debug.Log($"[Animal Status] Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}");

    }

    public abstract string Produce();
    
    
}
