using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Chicken chickenPrefab;
    public Cow cowPrefab;

    
    public List<Animal_Common> farmAnimals = new List<Animal_Common>();

    void Start()
    {
        
        Chicken chicken = Instantiate(chickenPrefab);
        Cow cow = Instantiate(cowPrefab);

        
        chicken.Init("Chicky", 10, 15);
        cow.Init("Milky", 20, 20);

        
        farmAnimals.Add(chicken);
        farmAnimals.Add(cow);
        
        
        Debug.Log("=== Welcome to Farm Yard ===");
        Debug.Log($"There are {farmAnimals.Count} animals living in the Farm Yard.");

        foreach (Animal_Common a in farmAnimals)
        {
            chicken.Init("Chicky", 10, 15);
            cow.Init("Milky", 20, 20);
            
            a.MakeSound();
            a.Food();


            a.GetStatus();
        }

        
    }
}
