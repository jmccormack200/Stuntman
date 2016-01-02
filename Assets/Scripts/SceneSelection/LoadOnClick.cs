using UnityEngine;
using UnityEngine.SceneManagement;

//https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/creating-a-scene-menu

public class LoadOnClick : MonoBehaviour
{

    public GameObject loadingImage;
    
    public void LoadScene(string level)
    {
        //loadingImage.SetActive(true);
        //Application.LoadLevel(level);
        SceneManager.LoadScene(level);
    }
}