using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadAdditive : MonoBehaviour
{
    
    public void LoadAddOnClick(int level)
    {
        
        SceneManager.LoadScene(level, LoadSceneMode.Additive);
        
    }
}