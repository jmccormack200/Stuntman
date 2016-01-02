using UnityEngine;
using System;
using System.Data;
using System.Collections;
using Mono.Data.Sqlite;


/// <summary>
/// Test for interacting with the SQLite Database.
/// We're probably going to leave this version of the database
/// around for way too long. Don't let that happen John. 
/// 
/// Source: http://answers.unity3d.com/questions/743400/database-sqlite-setup-for-unity.html
/// 
/// </summary>
public class helloDB : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//Path to database
		string conn = "URI=file:" + Application.dataPath + "/gameDB.db";

		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection (conn);
		dbconn.Open (); //Open the conection.
		IDbCommand dbcmd = dbconn.CreateCommand();

		//This is the actual sql command, it is then passed to the db command
		string sqlQuery = "SELECT value, name, rand " + "From PlaceSequence";
		dbcmd.CommandText = sqlQuery;
		IDataReader reader = dbcmd.ExecuteReader ();

		while (reader.Read ()) 
		{
			int value = reader.GetInt32 (0);
			string name = reader.GetString (1);
			int rand = reader.GetInt32 (2);

			Debug.Log ("value= " + value + "  name = " + name + " random = " + rand);
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
