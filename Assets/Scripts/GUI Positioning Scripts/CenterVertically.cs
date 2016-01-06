using UnityEngine;
using System.Collections;

public class CenterVertically : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Screen.height / 2, transform.position.z);
    }

    void Update()
    {

    }
}
