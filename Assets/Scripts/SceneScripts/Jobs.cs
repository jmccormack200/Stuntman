using UnityEngine;
using System.Collections;

public class Jobs : MonoBehaviour {

	
    public static IEnumerator bdayFire()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        yield return mp.ShowMessage("You set yourself on fire at a birthday! It was pretty awesome!");
        yield return mp.ShowMessage("You gained +1 to rep, -5 to health, + $10");
        Player player = Variables.player;
        player.incrementRep(1);
        player.decrementHealth(5);
        player.incrementMoney(10);
        //mp.updateMessage();


    }

    public static IEnumerator bdayPinata()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        yield return mp.ShowMessage("You play human pinata at a birthday! How sweet of you!");
        yield return mp.ShowMessage("You gained +1 to rep, -3 to health, + $5");
        Player player = Variables.player;
        player.incrementRep(1);
        player.decrementHealth(5);
        player.incrementMoney(5);
        //mp.updateMessage();

    }

    public static IEnumerator wheelie()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        yield return mp.ShowMessage("You do a reasonably long wheelie for some neighborhood kids! They were maginally impressed!");
        yield return mp.ShowMessage("You gained +1 to rep");
        Player player = Variables.player;
        player.incrementRep(1);
        //mp.updateMessage();


    }
}
