using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnSceneLoad : MonoBehaviour
{

	void OnLevelWasLoaded(int level)
    {
        MenuGenerator.GenerateMenu();
	}
}
