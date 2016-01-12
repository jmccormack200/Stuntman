using UnityEngine;
using System.Collections;

public class GameScreen : MonoBehaviour {

    //Player ThePlayer;
    //public static GameScreen Instance { get; private set; }
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
