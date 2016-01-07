using UnityEngine;
using System.Collections;

/// <summary>
/// Items class for creating item objects
/// from the database.
/// </summary>
public class Item
{
	public string name { get; private set; } 
    public string description { get; private set; }
    public string spritename { get; private set; }


    public Item(string name, string description, string spritename)
    {
        this.name = name;
        this.description = description;
        this.spritename = spritename;        
    }
}
