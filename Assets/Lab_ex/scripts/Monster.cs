using UnityEngine;


public class Monster : Character
{
    //Attributes


    private int lootReward;
    public int LootReward { get { return lootReward; }
        set
        {
            if (value < 0) { lootReward = 0; }
            else { lootReward = value; }
        }
    }
    //Constructor  -Create Object
    public void Init(string newName, int newHealth,int newAttackPower ,int newLootReward)
    {
        base.Init(newName, newHealth, newAttackPower);
        lootReward = newLootReward;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Monster Loot: {lootReward}");
    }

    //method
    public int DropReward()
    { 
        return LootReward; 
    }

    

   
}
