using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PowerSlider : MonoBehaviour {

    public int startingValue = 0;
    public int speed = 1;
    public int power = 0 ;
    private bool forward = true; // If true, value counts up. Counts down if false.
   
    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {

        // If power goes out of bounds, reverse direction
        if (power < 0 || power > 100)
            forward = !forward;

        if (forward) power += speed;
        else power -= speed;

        // For debug: output power to Text
        GetComponent<Text>().text = power.ToString();
    }

    public void Stop()
    {
        speed = 0;
    }
}
