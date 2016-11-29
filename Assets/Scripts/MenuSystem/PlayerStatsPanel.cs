using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStatsPanel : MonoBehaviour {

    public GameObject Player;
    public Text playerName;
    public Text rep;
    public Text health;
    public Text skill;
    public Text money;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        playerName.text = Variables.player.name.ToString();
        rep.text = Variables.player.rep.ToString();
        health.text = Variables.player.health.ToString();
        skill.text = Variables.player.skill.ToString();
        money.text = Variables.player.money.ToString();
    }
}
