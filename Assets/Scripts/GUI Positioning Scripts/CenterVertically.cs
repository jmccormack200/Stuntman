using UnityEngine;
using System.Collections;

/// <summary>
/// Centers the object horizontally with respects to screen height
/// </summary>
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
