using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour {

    public static Menu getMenu()
    {
        Option[] options = new Option[3];
        Menu menu;

        options[0] = new Option("Start Game", "startGame", 0);
        options[1] = new Option("Choose your Character", "chooseCharacter", 2);
        options[2] = new Option("Back", "back");
        menu = new Menu("NewGame", options);

        return menu;
    }

    //starts a new game by loading GameScreen scene
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

    //goes back to previous scene
    public static void back()
    {
       SceneManager.LoadScene("MainMenu");//load mainMenu
    }

}
