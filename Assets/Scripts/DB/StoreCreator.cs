using UnityEngine;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Mono.Data.Sqlite;


/// <summary>
/// This is used to poll the database and then generate the
/// inventory for the store. It will pull the sprite path, 
/// price, and quantity available. 
/// 
/// Another Object will need to either generate the store itself
/// or that could be done here. 
/// 
/// Descriptions of each item should be pulled from an item database
/// that would contain all of the items. 
/// 
/// Should probably move the image path to the generic item list too
/// 
/// </summary>
public class StoreCreator : MonoBehaviour {
	//Name of the Database
	public string databaseName = "/gameDB.db";
	public string tableName = "ItemsForStoreTable";

	//Sprite Dictionary to allow for finding the right sprite
	public Dictionary<string, Sprite> spriteDict = new Dictionary<string, Sprite>();

	// Use this for initialization
	void Start () 
	{
		//Path to database
		string conn = "URI=file:" + Application.dataPath + databaseName;

		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection (conn);
		dbconn.Open (); //Open the conection.
		IDbCommand dbcmd = dbconn.CreateCommand();

		//This is the actual sql command, it is then passed to the db command
		string sqlQuery = "SELECT name, price, imagepath, quantity " + "From " + tableName;
		dbcmd.CommandText = sqlQuery;
		IDataReader reader = dbcmd.ExecuteReader ();

		//Fill the sprite dictionary
		//Using this command requires all the sprites to be in a 
		//folder named sprites within a folder names Resources
		Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites");

		foreach (Sprite sprite in sprites)
		{
			print (sprite.name);
			spriteDict.Add (sprite.name, sprite);
		}

		//This dictionary doesnt really make sense right now as the 
		//name and path are the same, not sure if its worth leaving in
		//in case we want them to be able to be changed later
		Dictionary<string, string> names = new Dictionary<string, string>();

		while (reader.Read ()) 
		{
			string name = reader.GetString (0);
			//int price = reader.GetInt32 (1);
			string img = reader.GetString (2);
			//int quant = reader.GetInt32 (3);

			names.Add(name, img);

			Debug.Log ("  name = " + name + " path = " + img);
		}

		//for each item in the dictionary,
		//display the sprite
		//probably will want to rename them too
		//WILL need to move them into a pretty fashion
		//and ensure all the sizes are correct.

		foreach (string img in names.Values){
			GameObject item = new GameObject ();
			item.AddComponent<SpriteRenderer> ();
			print (img);
			item.GetComponent<SpriteRenderer> ().sprite = spriteDict[img];
		}

		//This will be to load the sprites
		//Should be turned into a function at some point



		reader.Close ();
		reader = null;
		dbcmd.Dispose ();
		dbcmd = null;
		dbconn.Close ();
		dbconn = null;
	}

	// Update is called once per frame
	void Update () 
	{

	}
}
