using UnityEngine;
using System.Collections;

public class GameScreen : MonoBehaviour {

    
    
    //Player ThePlayer;
    //public static GameScreen Instance { get; private set; }

    public static Menu getMenu()
    {
        Option[] options = new Option[4];
        Menu menu;

        options[0] = new Option("Train", "train", 0);
        options[1] = new Option("Fight", "fight", 2);
        options[2] = new Option("Stunt", "stunt");
        options[3] = new Option("Remember Dre.", "rememberDre");
        menu = new Menu("GameScreen", options);

        return menu;
    }   

    void Awake()
    {
        //Instance = this;
        
        
    }
    void Start()
    {
        //ThePlayer = FindObjectOfType<Player>();
        //gameScreen = new GameScreen();

    }

    static public void train()
    {
        //Player ThePlayer = FindObjectOfType<Player>();
        Player ThePlayer = Variables.player;
        Debug.Log(ThePlayer.skill);
        Debug.Log("You dun trained, bro.");
        ThePlayer.incrementSkill(1);
        Debug.Log(ThePlayer.skill);
    }

    static public void fight()
    {
        
        Debug.Log("Oh man, bro, you totally fought your own dang dad,bro.");
    }

    static public void stunt()
    {
        Debug.Log("woah, sweet stunt, bro.");
    }

    static public void rememberDre()
    {
        Debug.Log("Ya'll know me...");
    }
}
