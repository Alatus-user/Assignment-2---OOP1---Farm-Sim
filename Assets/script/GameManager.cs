using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{
    public Chicken chickenPrefab;
    public Cow cowPrefab;
    public Pig pigPrefab;
    
    public List<Animal_Common> farmAnimals = new List<Animal_Common>();

    void Start()
    {
        Debug.Log("=== Welcome to Farm Yard ===");
        Debug.Log($"There are {farmAnimals.Count} animals living in the Farm Yard.");
        
        Chicken chicken = Instantiate(chickenPrefab);
        Cow cow = Instantiate(cowPrefab);
        Pig pig = Instantiate(pigPrefab);
        
        chicken.Init("Chicky", 10, 15);
        chicken.GetStatus();

        cow.Init("Milky", 20, 20);
        cow.GetStatus();

        pig.Init("Piglet", 20, 20);
        pig.GetStatus();

        farmAnimals.Add(chicken);
        farmAnimals.Add(cow);
        farmAnimals.Add(pig);

        
        
        
        foreach (Animal_Common a in farmAnimals)
        {
            
            a.MakeSound();
            a.Food();
            a.Feed(5);

        }

        
    }
}
