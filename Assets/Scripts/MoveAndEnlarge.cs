using UnityEngine;
using System.Collections;

public class MoveAndEnlarge : MonoBehaviour 
{
    // Public variables to be changed in Unity
    public float moveX = 0f;
    public float moveY = 0f;
    public float scaleX = 0f;
    public float scaleY = 0f;

    public bool moveXRelativeToSideOfScreen = false;

    Vector3 startingPosition;
    Vector3 startingScale;

    // Use this for initialization
    void Start () 
    {
        // Assign game object's position and scale to local Vector3s
        startingPosition = gameObject.transform.position;
        startingScale = gameObject.transform.localScale;
    }
    
    // Update is called once per frame
    void Update () 
    {
        // Move object in the intended direction

        // If moveXRelativetoSideOfScreen is enabled,
        //   if object is on left of screen (x < 0)
        //   move object to left. Otherwise move right.
        if (moveXRelativeToSideOfScreen)
        {
            if (startingPosition.x < 0)
            {
                startingPosition.x -= moveX;
            }
            else
            {
                startingPosition.x += moveX;
            }
        }
        else
        {
            startingPosition.x += moveX;
        }
        startingPosition.y += moveY;

        // Scale object accordingly
        startingScale.x += scaleX;
        startingScale.y += scaleY;

        // Update transform
        gameObject.transform.localPosition = new Vector3(startingPosition.x, startingPosition.y, startingPosition.z);
        gameObject.transform.localScale = new Vector3(startingScale.x, startingScale.y, startingScale.z);
        
        // DEBUG
        //print("X=" + startingPosition.x.ToString());
        //print("Y=" + startingPosition.y.ToString());
        //print("sX=" + startingScale.x.ToString());
        //print("sY=" + startingScale.y.ToString());
    }
}
