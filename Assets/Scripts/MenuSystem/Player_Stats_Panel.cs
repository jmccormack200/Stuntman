using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_Stats_Panel : MonoBehaviour {

    public GameObject Player;
    public Text Rep;
    public Text Health;
    public Text Skill;
    public Text Money;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Rep.text = Variables.player.rep.ToString();
        Health.text = Variables.player.health.ToString();
        Skill.text = Variables.player.skill.ToString();
        Money.text = Variables.player.money.ToString();
    }
}
