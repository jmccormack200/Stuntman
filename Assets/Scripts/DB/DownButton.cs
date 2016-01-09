using UnityEngine;
using System.Collections;

public class DownButton : MonoBehaviour
{
	void OnMouseDown()
	{
		print ("Test");
		Transform inventory = transform.parent.transform;
		int maximum = inventory.GetComponent<InventoryBuilder> ().itemList.Count;
		int numScreens = inventory.GetComponent<InventoryBuilder> ().numberOfScreens;
		int position = inventory.GetComponent<InventoryBuilder> ().positionInList;

		if (position + numScreens <= maximum) {
			inventory.GetComponent<InventoryBuilder> ().positionInList = numScreens + position;
		} else
		{
			print ("End");
		}
	}
}
