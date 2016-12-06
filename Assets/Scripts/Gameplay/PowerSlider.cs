using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PowerSlider : MonoBehaviour {
        
    public float power = 0 ;
    public float speed = 2f;
    private bool stop = false;
    private float localYscale;
   
    // Use this for initialization
    void Start () {
        localYscale = transform.localScale.y;
        // Horizontally scale bar to zero
        transform.localScale = new Vector2(0f, localYscale);
    }
    
    // Update is called once per frame
    void Update () {

        if (!stop)
        {
            power = (power + (speed * Time.deltaTime)) % 100;
            transform.localScale = new Vector2(power / 100, localYscale);

            // For debug: output power to Text
            GameObject.Find("txtPower").GetComponent<Text>().text = power.ToString();
        }
    }

    public void Trigger()
    {
        stop = !stop;
    }
    
    public void Stop()
    {
        stop = true;
    }
}
