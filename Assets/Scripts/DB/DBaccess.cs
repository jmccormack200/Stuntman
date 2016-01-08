using UnityEngine;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Mono.Data.Sqlite;

/// <summary>
/// Used to directly access database objects
/// </summary>
public static class DBaccess
{
    /// <summary>
    /// Retrieves a random body part from the database. To be used with the Illness Generator.
    /// </summary>
    /// <returns>A string containing a body part name.</returns>
    public static string getIllnessBodyPart()
    {
		string part =""; // Fill with a placeholder in case DB is not working

		try{
			//Path to database
			string conn = "URI=file:" + Application.dataPath + "/gameDB.db";
			IDbConnection dbconn;
			dbconn = (IDbConnection)new SqliteConnection (conn);
			dbconn.Open (); //Open the conection.
			IDbCommand dbcmd = dbconn.CreateCommand();

			//This is the actual sql command, it is then passed to the db command
			string sqlQuery = "SELECT bodypart FROM IllnessBodyPart ORDER BY RANDOM() LIMIT 1" ;
			dbcmd.CommandText = sqlQuery;
			IDataReader reader = dbcmd.ExecuteReader ();


			//Build out the dictionary from the DB
			while (reader.Read ()) 
			{
				part = reader.GetString (0);
			}

			reader.Close ();
			reader = null;
			dbcmd.Dispose ();
			dbcmd = null;
			dbconn.Close ();
			dbconn = null;
		} catch {
			part = "Face";
		}

        // DO magic DB stuff

        return part;
    }

    /// <summary>
    /// Retrieves a random body part from the database. To be used with the Illness Generator.
    /// </summary>
    /// <returns>A string containing the name of an ailment.</returns>
    public static string getIllnessAilment()
    {
        string ailment=""; // Fill with a placeholder in case DB is not working

		try{
			//Path to database
			string conn = "URI=file:" + Application.dataPath + "/gameDB.db";

			IDbConnection dbconn;
			dbconn = (IDbConnection)new SqliteConnection (conn);
			dbconn.Open (); //Open the conection.
			IDbCommand dbcmd = dbconn.CreateCommand();

			//This is the actual sql command, it is then passed to the db command
			string sqlQuery = "SELECT ailment FROM IllnessAilment ORDER BY RANDOM() LIMIT 1" ;
			dbcmd.CommandText = sqlQuery;
			IDataReader reader = dbcmd.ExecuteReader ();


			//Build out the dictionary from the DB
			while (reader.Read ()) 
			{
				ailment = reader.GetString (0);
			}

			reader.Close ();
			reader = null;
			dbcmd.Dispose ();
			dbcmd = null;
			dbconn.Close ();
			dbconn = null;
		} catch {
			ailment = "Leprosy";
		}

        return ailment;
    }
}
