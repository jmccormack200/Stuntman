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

        try
        {           
            string sqlQuery = "SELECT bodypart FROM IllnessBodyPart ORDER BY RANDOM() LIMIT 1" ;
            getStringFromDB(sqlQuery);
            
        } 
        catch {
            part = "Face";
        }
        
        return part;
    }

    /// <summary>
    /// Retrieves a random body part from the database. To be used with the Illness Generator.
    /// </summary>
    /// <returns>A string containing the name of an ailment.</returns>
    public static string getIllnessAilment()
    {
        string ailment=""; // Fill with a placeholder in case DB is not working

        try
        {
            string sqlQuery = "SELECT ailment FROM IllnessAilment ORDER BY RANDOM() LIMIT 1" ;
            ailment = getStringFromDB(sqlQuery);
            
        } catch {
            ailment = "Leprosy";
        }

        return ailment;
    }

    private static string getStringFromDB(string sqlQuery)
    {
        //Path to database
        string returnString = ""; 
        string conn = "URI=file:" + Application.dataPath + Constants.DBlocation;

        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection (conn);
        
        IDbCommand dbcmd = dbconn.CreateCommand();

        //This is the actual sql command, it is then passed to the db command
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader ();

        try
        {
            dbconn.Open(); //Open the conection.

            while (reader.Read())
            {
                returnString = reader.GetString(0);
            }
        }
        catch
        {
            // Implement Error handling
            returnString = "ERROR";
        }
        finally
        {
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            dbconn = null;
        }
        return returnString;
    }
}


