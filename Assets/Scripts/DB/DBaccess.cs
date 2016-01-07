using UnityEngine;
using System.Collections;

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
        string part = "Face"; // Fill with a placeholder in case DB is not working

        // DO magic DB stuff

        return part;
    }

    /// <summary>
    /// Retrieves a random body part from the database. To be used with the Illness Generator.
    /// </summary>
    /// <returns>A string containing the name of an ailment.</returns>
    public static string getIllnessAilment()
    {
        string ailment = "Leprosy"; // Fill with a placeholder in case DB is not working

        // Do magic DB stuff

        return ailment;
    }
}
