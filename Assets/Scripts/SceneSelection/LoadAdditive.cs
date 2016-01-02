using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadAdditive : MonoBehaviour
{
    
    public void LoadAddOnClick(string level)
    {
        
        SceneManager.LoadScene(level, LoadSceneMode.Additive);
        
    }
}