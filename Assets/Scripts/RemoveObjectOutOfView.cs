using UnityEngine;
using System.Collections;

public class RemoveObjectOutOfView : MonoBehaviour {

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
