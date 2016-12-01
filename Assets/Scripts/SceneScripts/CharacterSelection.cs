using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;


public class CharacterSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChooseCharacter(string character)
    {
        if (character == Constants.characters.Zj.ToString())
        {
            Variables.player = new Player(5, 50, 5, 50, "Zj");
            
        }
        else if(character == Constants.characters.Jesse.ToString())
        {
            Variables.player = new Player(10, 150, 1, 50, "Jesse");
        }
        else if(character == Constants.characters.John.ToString())
        {
            Variables.player = new Player(1, 100, 10, 100, "John");
        }
        else
        {
            throw new System.ArgumentException("Not a recognized character name!");
        }
        SceneManager.LoadScene("GameScreen");
    }
}
