using UnityEngine;
using System.Collections.Generic;
public class Main : MonoBehaviour
{


    public Hero hero;
    public List<Monster> monstersPrefabs;

    public Monster currentMonster;

    public List<Monster> monsters= new List<Monster>();
    //private List<Monster> monsters = new List<Monster>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     //player
        hero.Init("Arthur", 20, 10);
        hero.ShowStat();

        //spawn Goblin
        //spawn monster game object from prefab
        currentMonster = Instantiate(monstersPrefabs[0]);

        //initialization
        currentMonster.Init("Goblin" , 100 , 10 , 50);
        currentMonster.ShowStat();
        // keep track of monster spawn in scene
        monsters.Add(currentMonster);
        
        
        //spawn Dragon
        //spawn monster game object from prefab
        currentMonster = Instantiate(monstersPrefabs[1]);

        //initialization
        currentMonster.Init("Dragon" , 200 , 20 , 500);
        currentMonster.ShowStat();
        // keep track of monster spawn in scene
        monsters.Add(currentMonster);
        
        
        //spawn Orc
        //spawn monster game object from prefab
        currentMonster = Instantiate(monstersPrefabs[2]);

        //initialization
        currentMonster.Init("Orc" ,300 , 30 , 600);
        currentMonster.ShowStat();
        // keep track of monster spawn in scene
        monsters.Add(currentMonster);

        






        /*//Create New Object Hero
        Hero hero = new Hero("Knight" , 20 , 50);

        //Create New Object Monster
        Monster monster = new Monster("Dark Lord" , 100 , 10 , 15);
        Monster monster2 = new Monster("Ligtning Lord" , 100 , 20 , 20);
        Monster monster3 = new Monster("Fire Lord" , 100 , 30 , 25);

        monsters.Add(monster);
        monsters.Add(monster2);
        monsters.Add(monster3);
        monsters.Add(new Monster("Evil King" , 100 , 40 , 30)); //add‡¢È“‰ªµÕπ √È“ß





        //show Object
        hero.ShowStat();

        //edit hero attribute
        hero.Name = "";
        hero.Health = 10000;

        //hero taken damage
        hero.TakeDamge(monster.AttackPower);
        Debug.Log($"Hero Name: {hero.Name} | Hero Health: {hero.Health} | Hero Gold: {hero.Gold}");
        Debug.Log($"Is Hero Still Alive{hero.IsAlive()}");



        //show monster from List
        foreach(var m in monsters)
        {
            //Debug.Log($"Monster Name: {m.Name} | Monster Health: {m.Health}");
            m.ShowStat();
        }

        monster2.ShowStat();

        hero.Attack(monster2);
        
        monster2.ShowStat();
    }*/
    }




  
}
