using UnityEngine;
using System.Collections;

public class SeedRandom : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnityEngine.Random.InitState(1337 * (int)Time.time);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
