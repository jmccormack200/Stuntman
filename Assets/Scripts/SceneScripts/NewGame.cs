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
        ModalPanel mp = FindObjectOfType <ModalPanel>();
        mp.ShowMessage("Stop being so picky!");
        mp.ShowMessage("Previous Skill: " + Variables.player.skill.ToString());
        Variables.player.incrementSkill(1);
        mp.ShowMessage("Current Skill: " + Variables.player.skill.ToString());
            
    }

    //goes back to previous scene
    public static void back()
    {
       SceneManager.LoadScene("MainMenu");//load mainMenu
    }

}
