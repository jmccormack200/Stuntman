using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//http://answers.unity3d.com/questions/993570/instantiate-prefab-button-texture-with-attached-sc.html

public class ButtonGenerator : MonoBehaviour {

    //GenerateButton
    //Generates a Button
    public void GenerateButton(string name)
    {
        
        GameObject newButton = (GameObject)Instantiate(Resources.Load("Prefabs/BtnPrefab"));
        //if (canvas == null)
        //{
            GameObject newCanvas = new GameObject("canvas", typeof(Canvas));
            newButton.transform.SetParent(newCanvas.transform);
        //}
        //else
        //{
        //    newButton.transform.SetParent(canvas.transform, false);
        //}

        newButton.name = name;
        Debug.Log(newButton.GetComponentInChildren<Text>().text);
        newButton.GetComponentInChildren<Text>().text = name;
        Debug.Log(newButton.GetComponentInChildren<Text>().text);
    }

} 
