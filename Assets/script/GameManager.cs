using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        // new ได้เพราะ Chicken/Cow เป็นคลาสธรรมดาแล้ว
        Chicken chicken = new Chicken("Clucker", 50, 50, 0);
        Cow cow = new Cow("Otis", 50, 50, 0);

        chicken.GetStatus();
        cow.GetStatus();

        Debug.Log("---- Welcome to Barn ----");

        chicken.MakeSound();
        chicken.Feed("Corn");
        chicken.Sleep();
        chicken.AdjustHunger(15);
        chicken.AdjustHappiness(-5);

        cow.MakeSound();
        cow.Feed("Hay");
        cow.Sleep();
        cow.AdjustHunger(-10);
        cow.AdjustHappiness(5);

        Debug.Log("---- After Actions ----");
        chicken.GetStatus();
        cow.GetStatus();
    }
}
