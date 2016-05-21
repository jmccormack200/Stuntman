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
    private Queue messageQueue;
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
    
    void Awake()
    {
        messageQueue = new Queue();
    }

    void Update()
    {
        if (modalPanelObject.activeInHierarchy)//active message, check for user input to close panel/show next message
        {
            CheckInput();
        }
        else if(messageQueue.Count > 0)//if no panel, check if messages in queue to be shown
        {
            UpdateMessage();
        }
    }

    
    //ShowMessage takes a message string and waits to display it until current message is closed
    public IEnumerator ShowMessage(string message)
    {
        
        yield return new WaitWhile(delegate { return modalPanelObject.activeInHierarchy; });//wait until panel is not activated
        {
            Debug.Log(message + " - No active modal panel object");
            Debug.Log(message + " - " + modalPanelObject.activeInHierarchy);
            modalPanelObject.SetActive(true);//activate panel
            Debug.Log(message + " - " + modalPanelObject.activeInHierarchy);
            this.message.text = message;//update message
        }
        /*
        if (modalPanelObject.activeInHierarchy)//pop up already showing
        {
            queueMessage(message);//queue the message
        }
        else//enable panel and change text
        {
            modalPanelObject.SetActive(true);

            this.message.text += message + "\n";//append message, so if more than one message is sent while panel is enabled, all get shown
        }
       */
    }

    //updates message text if there are messages in queue
    public void UpdateMessage()
    {
        Debug.Log("Updating Message");
        if(messageQueue.Count > 0)//stuff in queue
        {
            if(!modalPanelObject.activeInHierarchy)//show pop up
            {
                modalPanelObject.SetActive(true);
                //foreach (Button btn in FindObjectsOfType<Button>())
                //{
                //    btn.interactable = false;//disable button inputs
                //}
            }
            message.text = (string)messageQueue.Dequeue();//update message with first message
        }
    }

    public void ClosePanel()
    {
        
       
        modalPanelObject.SetActive(false);//close message box
        //foreach (Button btn in FindObjectsOfType<Button>())
        //{
        //    btn.interactable = true;//enable button inputs
        //}

    }

    public void CheckInput()
    {
        //Debug.Log("Checking Input");
        if (Input.anyKeyDown)//if key pressed
        {
            //ClosePanel();
            //return;
            if (messageQueue.Count <= 0)//no messages in queue
            {
                ClosePanel();//close panel
            }
            else//still messages in queue
            {
                UpdateMessage();//update message
            }
        }
    }

    public void QueueMessage(string msg)
    {
        messageQueue.Enqueue(msg);
    }
}

