using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Chicken chickenPrefab;
    public Cow cowPrefab;
    public Pig pigPrefab;

    public List<Animal_Common> farmAnimals = new List<Animal_Common>();

    void Start()
    {
        Debug.Log("=== Welcome to Farm Yard ===");

        Chicken chicken = Instantiate(chickenPrefab);
        Cow cow = Instantiate(cowPrefab);
        Pig pig = Instantiate(pigPrefab);

        farmAnimals.Add(chicken);
        farmAnimals.Add(cow);
        farmAnimals.Add(pig);

        Debug.Log($"There are {farmAnimals.Count} animals living in the Farm Yard.");


        // แสดง Stat ของทุกตัว
        cow.Init("Otis", 50, 50);
        chicken.Init("Micheal", 50, 50);
        pig.Init("Piglet", 50, 50);
        foreach (Animal_Common a in farmAnimals)
        {
            a.GetStatus();
        }

        Debug.Log("--- Feeding Time ---");

        cow.Feed(FoodType.Hay, 20); 
        chicken.Feed(FoodType.RottenFood, 20); 
        pig.Feed(FoodType.AnimalFood, 20);

        Debug.Log("--- Production Phase ---");
        foreach (Animal_Common a in farmAnimals)
        {
            string result = a.Produce();
            Debug.Log(result);
        }

        Debug.Log("--- Final Stat ---");
        foreach (Animal_Common a in farmAnimals)
        {
            a.GetStatus();
        }
    }
}
