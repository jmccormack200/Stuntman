using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuGenerator : MonoBehaviour {

    //Generates Menu for scene from DB
    static public void GenerateMenu()
    {
        Scene scene = SceneManager.GetActiveScene();//get current scene

        //Menu menu = DatabaseGetMenu(sceneName) or whatever this function will eventually be

        //create some test Options/Menu
        Option[] options = new Option[4];
        options[0] = new Option("Train", "train", 0);
        options[1] = new Option("Fight", "fight", 2);
        options[2] = new Option("Stunt", "stunt");
        options[3] = new Option("Remember Dre.", "rememberDre");
        Menu menu = new Menu("Test Menu", options);

        //create canvas for menu
        GameObject newCanvas = new GameObject("Canvas", typeof(Canvas));
        newCanvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;//set rendermode to Screen Space Overlay for reasons
        newCanvas.transform.position = Vector3.zero;//center canvas

        //GameObject title = new GameObject("text", typeof(Text));
        //title.transform.SetParent(newCanvas.transform);
        //title.AddComponent<Text>();
        //title.GetComponent<Text>().text = menu.name;
        //title.GetComponent<Text>().font = Font.CreateDynamicFontFromOSFont("Ariel", 20);
        
        //Create title
        Text thetext = newCanvas.AddComponent<Text>();
        thetext.transform.SetParent(newCanvas.transform);
        thetext.text = menu.name;
        thetext.font = Font.CreateDynamicFontFromOSFont("Ariel", 20);
        thetext.fontSize = 50;
        thetext.alignment = TextAnchor.UpperCenter;//center title

        Debug.Log(thetext.text);
        
        //create buttons
        GameObject tempButton;
        float y = 100.0f;//starting y value for buttons
        foreach (Option option in menu.options)//iterate through options and make a button for each one
        {
            tempButton = ButtonGenerator.GenerateButton(option.name);//create new Button
            tempButton.transform.SetParent(newCanvas.transform);//set new buttons parent canvas
            tempButton.transform.position = new Vector3(0.0f, y, 0.0f);
            y -= 50;//decrement y so each button is lower than the last
            

        }


    }
}
