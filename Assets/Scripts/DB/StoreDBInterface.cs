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
public class StoreDBInterface : MonoBehaviour {
	//Name of the Database
	public string databaseName = "/gameDB.db";
	public string tableName = "ItemsForStoreTable";
	//All relevant information will be stored in this dictionary. 
	//Any expansion to functionality should first be made to the Item class. 
	public Dictionary<string, Items> itemDict = new Dictionary<string, Items>();

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
		string sqlQuery = "SELECT name, spritename, desc " + "From " + tableName;
		dbcmd.CommandText = sqlQuery;
		IDataReader reader = dbcmd.ExecuteReader ();


		//Build out the dictionary from the DB
		while (reader.Read ()) 
		{
			string name = reader.GetString (0);
			string spritename = reader.GetString (1);
			string desc = reader.GetString (2);

			Items nextItem = new Items (name, spritename, desc);

			itemDict.Add(name, nextItem);

			Debug.Log ("  name = " + name + " path = " + spritename);
		}

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
