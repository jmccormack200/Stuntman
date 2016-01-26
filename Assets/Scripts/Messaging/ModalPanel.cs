using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//https://unity3d.com/learn/tutorials/modules/intermediate/live-training-archive/modal-window?playlist=17111

//  This script will be updated in Part 2 of this 2 part series.
public class ModalPanel : MonoBehaviour
{

    public Text message;
    
    public GameObject modalPanelObject;

    private static ModalPanel modalPanel;

    public static ModalPanel Instance()
    {
        if (!modalPanel)
        {
            modalPanel = FindObjectOfType(typeof(ModalPanel)) as ModalPanel;
            if (!modalPanel)
                Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
        }

        return modalPanel;
    }
    
    void Update()
    {
        CheckInput();
    }
    // Yes/No/Cancel: A string, a Yes event, a No event and Cancel event
    public void ShowMessage(string message)
    {
        modalPanelObject.SetActive(true);

       this.message.text += message + "\n";//append message, so if more than one message is sent while panel is enabled, all get shown

       
    }

    public void ClosePanel()
    {
        this.message.text = "";//clear message
        modalPanelObject.SetActive(false);
        
    }

    public void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            ClosePanel();
        }
    }
}

