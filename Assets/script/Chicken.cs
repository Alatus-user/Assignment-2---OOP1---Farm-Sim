using System;
using UnityEngine;

public class Chicken : Animal_Common
{
    private int eggs;

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

    public override void Init(string name, int hunger, int happiness)
    {
        base.Init(name, hunger, happiness);

        Eggs = eggs;
    }



    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Clucky");
    }

    public override void Food()
    {
        Debug.Log($"{Name} eat: seed!");
    }

    public void Sleep()
    {
        AdjustHunger(-5);
        AdjustHappiness(+10);
        Debug.Log($"{Name} is sleeping...zzzzzzz");
    }

    




}
