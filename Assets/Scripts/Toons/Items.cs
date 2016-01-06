using UnityEngine;
using System.Collections;

/// <summary>
/// Items class for creating item objects
/// from the database.
/// </summary>
public class Items
{
	public string itemname{ get; set; }
	public string spritename{ get; set; }
	public string desc{ get; set;}

	public Items ()
	{

	}

	public Items(string iname, string sname, string d)
	{
		itemname = iname;
		spritename = sname;
		desc = d;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
