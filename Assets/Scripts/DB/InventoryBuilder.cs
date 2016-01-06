using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryBuilder : MonoBehaviour 
{
	public string tagname = "ItemSpriteScreen";
	public Dictionary<string, Items> itemDict = new Dictionary<string, Items>();
	public List<GameObject> screenList;
	public Sprite TESTSPRITE; 

	// Use this for initialization
	void Start () 
	{
		StoreDBInterface dbinterface = new StoreDBInterface ();
		itemDict = dbinterface.fetchItemsAsDictionary ();

		//Get the list of 6 screens we will be displaying on
		//It may be quicker to do this in the editor manually 
		//rather than here programatically
		screenList = new List<GameObject>();

		foreach (Transform child in gameObject.transform) 
		{
			if (child.tag == tagname)
			{
				child.transform.GetChild(0).GetComponent<SpriteRenderer> ().sprite = TESTSPRITE;
			}
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


}
