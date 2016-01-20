using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour 
{
    public GameObject spawnedObject = null;
    public int everyNumberOfFrames = 10;

    // Starting position of object
    public float startX = 0f;
    public float startY = 0f;
    public float startZ = 0f;

    // For randomizing starting position
    public bool randomize = false;
    public float minX = 0f, maxX = 0f, minY = 0f, maxY = 0f; // range of Minimum/Maximum X,Y values to spawn object

    private int i; // private i. Get it?
    private Vector3 startingPosition; // Used to set object's initial position

    // Use this for initialization
    void Start () 
    {
        i = 0;
    }
    
    // Update is called once per frame
    void Update () 
    {
        i++;
        if (i % everyNumberOfFrames == 0)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        if (randomize)
        {
            RandomizeStartingPosition();
        }

        startingPosition = new Vector3(startX, startY, startZ); // Create starting position

        GameObject obj = Instantiate(spawnedObject); // Create new object
        obj.transform.position = startingPosition; // Set starting position
        obj.transform.parent = gameObject.transform; // Set current object as parent
    }

    void RandomizeStartingPosition()
    {        
        startX = Random.Range(minX, maxX);
        startY = Random.Range(minY, maxY);
    }
}
