using UnityEngine;
using System;
using System.Collections;
using System.Reflection;

public class GameScreen : MonoBehaviour {



    //Player ThePlayer;
    public static GameScreen Instance { get; private set; }

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

    //constructor
    GameScreen()
    {
        Instance = this;
    }

    void Awake()
    {
        //Instance = this;


    }
    void Update()
    {
        //if(Instance == null)
        //{ Instance = new GameScreen(); }
    }
    void Start()
    {
        //ThePlayer = FindObjectOfType<Player>();
        //gameScreen = new GameScreen();

    }

    //train to increase your skill
    static public void train()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();//get ModalPanel
        
        //Player ThePlayer = FindObjectOfType<Player>();
        Player ThePlayer = Variables.player;
        
        mp.QueueMessage("Previous skill: " + ThePlayer.skill.ToString());
        mp.QueueMessage("You dun trained, bro.");
        ThePlayer.incrementSkill(1);
        mp.QueueMessage("Current skill: " + ThePlayer.skill.ToString());
        

        ActionManager.Instance.decrementActionsLeft();
    }

    //fight your step dad
    static public void fight()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        
        Player ThePlayer = Variables.player;
        
        UnityEngine.Random.InitState((int)Time.time);//seed random for fight chance
        
        mp.QueueMessage("Oh man, bro, you're totally 'bout to fight your own dang dad,bro.");
        
        float fightChance = UnityEngine.Random.value + ThePlayer.skill/100;//1% chance increase per skill level
        if(fightChance > Variables.dadSkill)//won fight, gain rep
        {
           mp.QueueMessage("You totally dun kicked your dad's butt, yo!");
           ThePlayer.incrementRep(1);
           mp.QueueMessage("Your rep is now " + ThePlayer.rep);
        }
        else//lost fight, lose health
        {
            mp.QueueMessage("Aww shucks, you got your dang butt beat up, son!");           
            ThePlayer.decrementHealth(1);                    
            mp.QueueMessage("Your health is now " + ThePlayer.health);
            
        }
        
        ActionManager.Instance.decrementActionsLeft();
        

    }

    //do a stunt
    static public void stunt()
    {
    
       ModalPanel mp = FindObjectOfType<ModalPanel>();
       mp.QueueMessage("woah, sweet stunt, bro.");

        
        ActionManager.Instance.decrementActionsLeft();
        
    }

    //get at random job
    static public void getJob()
    { 
        //ModalPanel mp = FindObjectOfType<ModalPanel>();
        UnityEngine.Random.InitState((int)Time.time);//seed Random number generator
        Type Jobs = Type.GetType("Jobs");//get the Jobs script
        
        MethodInfo[] jobs = Jobs.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly);//get the public, static, declared methods from Jobs, aka the jobs
        jobs[UnityEngine.Random.Range(0, jobs.Length)].Invoke(null, null);//choose a random job and invoke it
        //mp.StartCoroutine((IEnumerator)jobs[UnityEngine.Random.Range(0, jobs.Length)].Invoke(null, null));
        ActionManager.Instance.decrementActionsLeft();
        
    }
}
