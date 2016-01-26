using UnityEngine;
using System.Collections;

public class Jobs : MonoBehaviour {

	
    public static void bdayFire()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        mp.ShowMessage("You set yourself on fire at a birthday! It was pretty awesome!");
        mp.ShowMessage("You gained +1 to rep, -5 to health, + $10");
        Player player = Variables.player;
        player.incrementRep(1);
        player.decrementHealth(5);
        player.incrementMoney(10);
    }

    public static void bdayPinata()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        mp.ShowMessage("You play human pinata at a birthday! How sweet of you!");
        mp.ShowMessage("You gained +1 to rep, -3 to health, + $5");
        Player player = Variables.player;
        player.incrementRep(1);
        player.decrementHealth(5);
        player.incrementMoney(5);
    }

    public static void wheelie()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        mp.ShowMessage("You do a reasonably long wheelie for some neighborhood kids! They were maginally impressed!");
        mp.ShowMessage("You gained +1 to rep");
        Player player = Variables.player;
        player.incrementRep(1);
    }
}
