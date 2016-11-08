using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnSceneLoad : MonoBehaviour
{
     void Awake()
    {
        SceneManager.sceneLoaded += SceneLoaded;
    }
    //void OnLevelWasLoaded(int level)
    void SceneLoaded(Scene scene, LoadSceneMode laodSceneMode)
    {
        MenuGenerator.GenerateMenu();
	}
    void OnDestroy()
    {
        SceneManager.sceneLoaded -= SceneLoaded;
    }
}
