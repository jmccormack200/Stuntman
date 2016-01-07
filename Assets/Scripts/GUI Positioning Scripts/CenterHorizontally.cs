using UnityEngine;
using System.Collections;

/// <summary>
/// Centers the object horizontally with respects to screen width
/// </summary>
public class CenterHorizontally : MonoBehaviour
{

	// Use this for initialization
	void Start () 
	{
		transform.position = new Vector3(Screen.width / 2, transform.position.y, transform.position.z);
	}	

	void Update()
	{

	}
}
