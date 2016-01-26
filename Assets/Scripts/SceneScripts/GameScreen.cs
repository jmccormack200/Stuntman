using UnityEngine;
using System;
using System.Collections;
using System.Reflection;

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
        options[3] = new Option("Get a Job", "getJob");
        
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
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        mp.ShowMessage("Previous skill: " + ThePlayer.skill.ToString());
        mp.ShowMessage("You dun trained, bro.");
        ThePlayer.incrementSkill(1);
        mp.ShowMessage("Current skill: " + ThePlayer.skill.ToString());
    }

    //fight your step dad
    static public void fight()
    {
        Player ThePlayer = Variables.player;
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        UnityEngine.Random.seed = (int)Time.time;

        mp.ShowMessage("Oh man, bro, you're totally 'bout to fight your own dang dad,bro.");
        float fightChance = UnityEngine.Random.value + ThePlayer.skill/100;//1% chance increase per skill level
        if(fightChance > Variables.dadSkill)
        {
            mp.ShowMessage("You totally dun kicked your dad's butt, yo!");
            ThePlayer.incrementRep(1);
            mp.ShowMessage("Your rep is now " + ThePlayer.rep);
        }
        else
        {
            mp.ShowMessage("Aww shucks, you got your dang butt beat up, son!");
            ThePlayer.decrementHealth(1);
            mp.ShowMessage("Your health is now " + ThePlayer.health);
        }
        
    }

    static public void stunt()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        mp.ShowMessage("woah, sweet stunt, bro.");
    }

    static public void getJob()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        UnityEngine.Random.seed = (int)Time.time;//seed Random number generator
        Type Jobs = Type.GetType("Jobs");//get the Jobs script
        //mp.ShowMessage(Jobs);
        //mp.ShowMessage(Jobs.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length);
        MethodInfo[] jobs = Jobs.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly);//get the public, static, declared methods from Jobs, aka the jobs
        jobs[UnityEngine.Random.Range(0, jobs.Length)].Invoke(null, null);//choose a random job and invoke it
    }
}
