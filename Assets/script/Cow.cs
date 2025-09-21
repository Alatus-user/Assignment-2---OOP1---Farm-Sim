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

    public override void Init(string name, int hunger, int happiness)
    {
        base.Init(name, hunger, happiness);
        Milk = milk;
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
        Debug.Log($"{Name} eat:hay");
    }
}
