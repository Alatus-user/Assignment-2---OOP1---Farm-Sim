using UnityEngine;

 public class Hero : Character
{
    //Attributes
    private int gold;
    public int Gold
    {
        get { return gold; }
        set
        {
            if (value > 999) gold = 999;
            else if (value <= 0) { gold = 0; }
            else { gold = value; }
        }
    }


    //Constructor  -Create Object
    public override void Init(string newName, int newHealth, int newAttackPower)
    {
        base.Init(newName, newHealth, newAttackPower);
        Gold = 0;
    }
    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Hero Gold: {Gold}");
    }

    //EarnedGold
    public void EarnedGold(int amout)
    {
        if (amout > 0)
        {
            Gold += amout;
        }
    }
}

