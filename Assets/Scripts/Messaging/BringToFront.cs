using UnityEngine;
using System.Collections;

public class BringToFront : MonoBehaviour {

    //when element is enabled, set it as last sibling
    void OnEnable()
    {
        transform.SetAsLastSibling();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
