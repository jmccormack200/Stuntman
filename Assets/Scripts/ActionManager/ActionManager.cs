﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ActionManager : MonoBehaviour {


    public int actionsPerDay;//how many actions the player can perform per day
    public int actionsLeft;//number of actions remaining for the day
    
    public int month {get; private set; }//current month
    public int day { get; private set; }//current day

    static public ActionManager Instance;

    ActionManager(int actionsPerDay = 2, int month = 1, int day = 1 )
    {
        this.month = month;
        this.day = day;
        actionsLeft = this.actionsPerDay = actionsPerDay;

        Instance = this;
    }

	// Use this for initialization
	void Start () {
        if(Instance == null)
        {
            Instance = this;
            this.month = 1;
            this.day = 1;
            actionsLeft = actionsPerDay=2;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //decrements number of actions left for the day and returns number of actions left
    //updates day/month as necessary
    public int decrementActionsLeft(int actions = 1)
    {
        ModalPanel mp = FindObjectOfType<ModalPanel>();
        mp.modalPanelObject.GetComponentInChildren<Text>().text = "";
        //mp.QueueMessage("Current ActionsLeft: " + actionsLeft);
        actionsLeft--;//decrement # of actions left
        mp.QueueMessage("ActionsLeft: " + actionsLeft);
        if (actionsLeft <=0 )//out of actions
        {
            mp.QueueMessage("Out of Actions, New Day!");
            actionsLeft = actionsPerDay;//refresh actions
            day++;
            
            if (day >30)//new month
            {
                day = 0;
                month++;
                mp.QueueMessage("New Month!");
            }
        }
        mp.QueueMessage(string.Format("Month {0}, Day {1}",month, day));
        
        return actionsLeft;
    }
}
