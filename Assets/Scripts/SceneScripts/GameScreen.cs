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

    //train to increase your skill
    static public void train()
    {
        //Player ThePlayer = FindObjectOfType<Player>();
        Player ThePlayer = Variables.player;
        Debug.Log(ThePlayer.skill);
        Debug.Log("You dun trained, bro.");
        ThePlayer.incrementSkill(1);
        Debug.Log(ThePlayer.skill);
    }

    //fight your step dad
    static public void fight()
    {
        Player ThePlayer = Variables.player;
        Random.seed = (int)Time.time;

        Debug.Log("Oh man, bro, you're totally 'bout to fight your own dang dad,bro.");
        float fightChance = Random.value + ThePlayer.skill/100;//1% chance increase per skill level
        if(fightChance > Variables.dadSkill)
        {
            Debug.Log("You totally dun kicked your dad's butt, yo!");
            ThePlayer.incrementRep(1);
            Debug.Log("Your rep is now " + ThePlayer.rep);
        }
        else
        {
            Debug.Log("Aww shucks, you got your dang butt beat up, son!");
            ThePlayer.decrementHealth(1);
            Debug.Log("Your health is now " + ThePlayer.health);
        }
        
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
