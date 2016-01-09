using UnityEngine;
using System.Collections;


/// <summary>
/// Down button. script, this should be replaced and
/// deleted shortly. 
/// </summary>
/// /*
/*
public class DownButton : MonoBehaviour
{
	void DownButtonArrow()
	{
		print ("Test");
		Transform inventory = transform.parent.transform;
		int maximum = inventory.GetComponent<InventoryBuilder> ().itemList.Count;
		int numScreens = inventory.GetComponent<InventoryBuilder> ().numberOfScreens;
		int position = inventory.GetComponent<InventoryBuilder> ().positionInList;

		//if (position + numScreens <= maximum) {
			inventory.GetComponent<InventoryBuilder> ().positionInList = numScreens + position;
		inventory.GetComponent<InventoryBuilder> ().LoadScreens ();
		//} else
		//{
		//	print ("End");
		//}
	}
}
*/