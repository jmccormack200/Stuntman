using UnityEngine;
using System.Collections;

public class IllnessGenerator{

	/// <summary>
	/// Generates a new illness.
	/// </summary>
	/// <returns>The name of illness as a string.</returns>
	public string getIllness()
	{
		string illness, prefix, suffix;
		prefix = getPrefix (); // First part of name (body part)
		suffix = getSuffix (); // Second part of name (ailment)

		// If ailment begins with '-' (like "-itis"), do not add space between words.
		if (suffix [0] == '-') 
		{
				illness = prefix + suffix;
		} 
		else // Otherwise add a space between words
		{
				illness = prefix + " " + suffix;
		}

		return illness;
	}

	// Gets first half of name from database
	private string getPrefix()
	{
		// Database Access function
		return DBaccess.getIllnessBodyPart();
	}

	// Gets second half of name from database
	private string getSuffix()
	{
		// Database Access function
		return DBaccess.getIllnessAilment();
	}
}
