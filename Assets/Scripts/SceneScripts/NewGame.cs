using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {

    public static Menu getMenu()
    {
        Option[] options = new Option[2];
        Menu menu;

        options[0] = new Option("Start Game", "startGame", 0);
        options[1] = new Option("Choose your Character", "chooseCharacter", 2);
        
        menu = new Menu("NewGame", options);

        return menu;
    }

    public static void startGame()
    {
       LoadOnClick loc = new LoadOnClick();
       loc.LoadScene("GameScreen");
    }

    public static void chooseCharacter()
    {
        Debug.Log("Stop being so picky!");
        Debug.Log(Variables.player.skill);
        Variables.player.incrementSkill(1);
        Debug.Log(Variables.player.skill);
    }

}
