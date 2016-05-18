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
        mp.StartCoroutine(trainHelper());
        
    }
    static public IEnumerator trainHelper()
    {
        //Player ThePlayer = FindObjectOfType<Player>();
        Player ThePlayer = Variables.player;
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        yield return mp.ShowMessage("Previous skill: " + ThePlayer.skill.ToString());
        yield return mp.ShowMessage("You dun trained, bro.");
        ThePlayer.incrementSkill(1);
        yield return mp.ShowMessage("Current skill: " + ThePlayer.skill.ToString());
        //mp.updateMessage();

        //ActionManager.Instance.decrementActionsLeft();
    }

    //fight your step dad
    static public void fight()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        //GameScreen GS = new GameScreen();
        //Debug.Log(GS);
        Debug.Log("fight! now call fightHelper");
        mp.StartCoroutine(fightHelper());
        Debug.Log("fightHelper was called.");
    }

    //Helper function since button handlers can't be IEnumerators
    static public IEnumerator fightHelper()
    {
        Debug.Log("fightHelper!");
        Player ThePlayer = Variables.player;
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        UnityEngine.Random.seed = (int)Time.time;
        Debug.Log("pre yield to show message bout to fight");
        yield return mp.ShowMessage("Oh man, bro, you're totally 'bout to fight your own dang dad,bro.");
        Debug.Log("post yield to show message bout to fight");
        float fightChance = UnityEngine.Random.value + ThePlayer.skill/100;//1% chance increase per skill level
        if(fightChance > Variables.dadSkill)
        {
            yield return mp.ShowMessage("You totally dun kicked your dad's butt, yo!");
            ThePlayer.incrementRep(1);
            yield return mp.ShowMessage("Your rep is now " + ThePlayer.rep);
        }
        else
        {
            Debug.Log("pre yield to show message aww shucks");
           yield return mp.ShowMessage("Aww shucks, you got your dang butt beat up, son!");
            Debug.Log("post yield to show message aww shucks");

            ThePlayer.decrementHealth(1);

            Debug.Log("pre yield to show message your health");
           yield return mp.ShowMessage("Your health is now " + ThePlayer.health);
            Debug.Log("post yield to show message your health");
        }
        //mp.updateMessage();
        //ActionManager.Instance.decrementActionsLeft();
        //return mp.ShowMessage("");

    }
    //do a stunt
    static public void stunt()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        mp.StartCoroutine(stuntHelper());
    }

    //Helper function for stunt since button handlers can't be IEnumerable
    static public IEnumerator stuntHelper()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        yield return mp.ShowMessage("woah, sweet stunt, bro.");

        //mp.updateMessage();
        //ActionManager.Instance.decrementActionsLeft();
        
    }

    //get at random job
    static public void getJob()
    //{
    //    ModalPanel mp = FindObjectOfType<ModalPanel>();
    //    mp.StartCoroutine(getJobHelper());
    //}
   // static public IEnumerable getJobHelper()
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        UnityEngine.Random.seed = (int)Time.time;//seed Random number generator
        Type Jobs = Type.GetType("Jobs");//get the Jobs script
        //yield return mp.ShowMessage(Jobs);
        //yield return mp.ShowMessage(Jobs.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length);
        MethodInfo[] jobs = Jobs.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly);//get the public, static, declared methods from Jobs, aka the jobs
        //jobs[UnityEngine.Random.Range(0, jobs.Length)].Invoke(null, null);//choose a random job and invoke it
        mp.StartCoroutine((IEnumerator)jobs[UnityEngine.Random.Range(0, jobs.Length)].Invoke(null, null));
        //ActionManager.Instance.decrementActionsLeft();
        //mp.updateMessage();
    }
}
