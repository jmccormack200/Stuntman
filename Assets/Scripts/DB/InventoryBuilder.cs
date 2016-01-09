using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryBuilder : MonoBehaviour 
{
	public string tagname = "ItemSpriteScreen";
	public List<Item> itemList = new List<Item>();
	public Dictionary<string, Sprite> spriteDict = new Dictionary<string, Sprite>();
	public Sprite TESTSPRITE; 
	public int numberOfScreens = 0;
	public int positionInList = 0;

	// Use this for initialization
	void Start () 
	{
		StoreDBInterface dbinterface = new StoreDBInterface ();
		itemList = dbinterface.fetchItemsAsList ();

		//Build out Sprite Dictionary
		Sprite[] sprites = Resources.LoadAll<Sprite> ("Sprites");

		foreach (Sprite sprite in sprites) {
			spriteDict.Add (sprite.name, sprite);
		}

		foreach (Transform child in gameObject.transform) 
		{
			if (child.tag == tagname) 
			{
				try 
				{
					numberOfScreens += 1;
				} catch 
				{

				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		LoadScreens ();
	}

	void LoadScreens()
	{
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
					child.transform.GetChild (0).GetComponent<SpriteRenderer> ().sprite = spriteDict [itemList [positionInList].spritename];
					positionInList += 1;
					print(positionInList);
				} catch 
				{

				}
			}
		}
	}
}
