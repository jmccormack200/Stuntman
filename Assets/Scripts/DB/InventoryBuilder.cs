using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryBuilder : MonoBehaviour 
{
	public string tagname = "ItemSpriteScreen";
	public List<Item> itemList = new List<Item>();
	public List<GameObject> screenList;
	public Dictionary<string, Sprite> spriteDict = new Dictionary<string, Sprite>();
	public Sprite TESTSPRITE; 
	private int positionInList = 0;

	// Use this for initialization
	void Start () 
	{

		//JUST HOLDING THIS FOR A FRIEND, REMOVE AFTER CONFIRMED WORKING
		IllnessGenerator ig = new IllnessGenerator();
		string ailment = ig.getIllness ();
		print ("Your character has: " + ailment);
		//
		StoreDBInterface dbinterface = new StoreDBInterface ();
		itemList = dbinterface.fetchItemsAsList ();

		//Get the list of 6 screens we will be displaying on
		//It may be quicker to do this in the editor manually 
		//rather than here programatically
		screenList = new List<GameObject>();

		//Build out Sprite Dictionary
		Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites");
		//print ("Sprites Found Are:  ");
		foreach (Sprite sprite in sprites)
		{
		//	print (sprite.name);
			spriteDict.Add (sprite.name, sprite);
		}

//		print ("Sprites being printed are");
		foreach (Transform child in gameObject.transform) 
		{
			if (child.tag == tagname)
			{
				try
				{
					//The below line looks scary but fret not. Starting with the right side:
					//For each screen, we get its child (child of the variable child) then get the
					//sprite from the sprite renderer.
					//On the right we use the position to access the next item from the item list.
					//we use the spritename of the next item to access the sprite from the sprite
					//dictionary. 
					child.transform.GetChild(0).GetComponent<SpriteRenderer> ().sprite = spriteDict[itemList[positionInList].spritename];
//					print(itemList[positionInList].spritename);
					positionInList += 1;
				} catch 
				{
//					print ("Not Displaying");
//					print (itemList [positionInList].spritename);
				}
			}
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


}
