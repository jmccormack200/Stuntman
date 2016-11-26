using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ActionsPanel : MonoBehaviour {

    public ActionManager actionManager;
    public Text date;
    public Text actionsLeft;

	// Use this for initialization
	void Start () {
        actionManager = FindObjectOfType<ActionManager>();
	}
	
	// Update is called once per frame
	void Update () {
        actionsLeft.text = actionManager.actionsLeft.ToString();
        date.text = actionManager.month.ToString() + "/" + actionManager.day.ToString();
	}
}
