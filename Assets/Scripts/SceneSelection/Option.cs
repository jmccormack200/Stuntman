using UnityEngine;
using System.Collections;

public class Option : MonoBehaviour {

    private new string name { get; set; }//name of option - what will be shown on button
    private string func { get; set; }//function to call onClick
    private int unlockedAtLevel { get; set; }//rep level at which to unlock -need to discuss more how locking mechanism works(some things locked by rep? others money? etc)

    public Option(string name, string func, int unlockedAtLevel = 0)
    {
        this.name = name;
        this.func = func;
        this.unlockedAtLevel = unlockedAtLevel;
    }

    //returns true if player has rep higher than unlockedAtLevel
    public bool unlocked(Player player)
    {
        return player.rep > this.unlockedAtLevel;
    }
}
