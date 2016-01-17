using UnityEngine;
using System.Collections;

public class Jobs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void bdayFire()
    {
        Debug.Log("You set yourself on fire at a birthday! It was pretty awesome!");
        Debug.Log("You gained +1 to rep, -5 to health, + $10");
        Player player = Variables.player;
        player.incrementRep(1);
        player.decrementHealth(5);
        player.incrementMoney(10);
    }

    public static void bdayPinata()
    {
        Debug.Log("You play human pinata at a birthday! How sweet of you!");
        Debug.Log("You gained +1 to rep, -3 to health, + $5");
        Player player = Variables.player;
        player.incrementRep(1);
        player.decrementHealth(5);
        player.incrementMoney(5);
    }

    public static void wheelie()
    {
        Debug.Log("You do a reasonably long wheelie for some neighborhood kids! They were maginally impressed!");
        Debug.Log("You gained +1 to rep");
        Player player = Variables.player;
        player.incrementRep(1);
    }
}
