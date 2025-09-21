using System.Xml.Linq;
using UnityEngine;

public abstract class Character : MonoBehaviour
{


    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "UnName Hero"; }
            else { name = value; }
        }
    }

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    public int AttackPower { get;  set; }

    //Constructor  -Create Object
    public virtual void Init(string newName, int newHealth, int newAttackPower)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = newAttackPower;
    }









    //method
    public void TakeDamge(int damageValue)
    {
        Health -= damageValue;
    }

    //isAlive
    public bool IsAlive()
    {
        return Health > 0;
    }


    public virtual void ShowStat()
    {
        Debug.Log($"Hero Name: {Name} | Hero Health: {Health} | Hero Attack: {AttackPower}");

    }

    public void Attack(Monster target)
    {
        Debug.Log($"{Name} attack {target.Name} for {AttackPower} Damage!");
        target.TakeDamge(AttackPower);
    }
   
  
}
