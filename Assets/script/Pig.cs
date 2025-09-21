using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : Animal_Common
{

    public override void Init(string name, int hunger, int happiness)
    {
        base.Init(name, hunger, happiness);

    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Oink ");
    }

    public override void GetStatus()
    {
        base.GetStatus();
    }
} 
        


    

