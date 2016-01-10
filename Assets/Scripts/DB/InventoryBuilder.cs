using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class InventoryBuilder : MonoBehaviour 
{
	public string tagname = "ItemSpriteScreen";
	public List<Item> itemList = new List<Item>();
	public Dictionary<string, Item> itemDict = new Dictionary<string, Item>();
	public Dictionary<string, Sprite> spriteDict = new Dictionary<string, Sprite>();
	public Sprite TESTSPRITE; 
	public int numberOfScreens = 0;
	public int positionInList = 0;

	public GameObject downbutton;
	public GameObject upbutton;

	public GameObject textbox;

	// Use this for initialization
	void Start () 
	{
		//The upbutton should start disabled
		upbutton.GetComponent<Button> ().interactable = false;

		StoreDBInterface dbinterface = new StoreDBInterface ();
		itemList = dbinterface.fetchItemsAsList ();
		itemDict = dbinterface.fetchItemsAsDictionary ();

		//Build out Sprite Dictionary
		Sprite[] sprites = Resources.LoadAll<Sprite> ("Sprites");

		foreach (Sprite sprite in sprites) {
			spriteDict.Add (sprite.name, sprite);
		}

		foreach (Transform child in gameObject.transform) 
		{
			if (child.tag == tagname) 
			{
				numberOfScreens += 1;
			}
		}

		LoadScreens ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void LoadScreens()
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
					//print(positionInList);
				} catch 
				{
					child.transform.GetChild (0).GetComponent<SpriteRenderer> ().sprite = null;

				}
				positionInList +=1;
			}
		}
	}

	public void DownButton()
	{
		LoadScreens ();

		if (positionInList >= itemList.Count) {
			downbutton.GetComponent<Button> ().interactable = false;
		} 

		if (positionInList >= numberOfScreens) {
			upbutton.GetComponent<Button> ().interactable = true;
		}
	}

	public void UpButton()
	{
		//int maximum = itemList.Count;
		positionInList -= 2 * numberOfScreens; 
		LoadScreens ();

		if (positionInList <= numberOfScreens) {
			upbutton.GetComponent<Button> ().interactable = false;
		}

		if (positionInList <= itemList.Count) {
			downbutton.GetComponent<Button> ().interactable = true;
		} 
	}

	public void ScreenClick(GameObject screen)
	{
		Item item = itemDict[screen.GetComponent<SpriteRenderer>().sprite.name];

		foreach (Transform child in textbox.transform)
		{
			if (child.name == "Desc") {
				child.GetComponent<Text> ().text = item.description;
			} else if (child.name == "Name") {
				child.GetComponent<Text> ().text = "Name: " + item.name;
			} else if (child.name == "Cost") {
				child.GetComponent<Text> ().text = "Cost: " + item.cost.ToString ();
			} else {
				print ("no match");
			}
		}

	}
}
