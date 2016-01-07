using UnityEngine;
using System.Collections;

public class Item
{
    public string name { get; private set; } 
    public string description { get; private set; }
    public Sprite image { get; private set; }
    

    public Item(string name, string description, Sprite image)
    {
        this.name = name;
        this.description = description;
        this.image = image;        
    }
}
