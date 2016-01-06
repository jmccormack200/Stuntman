using UnityEngine;
using UnityEditor;

public class MenuItems
{
    [MenuItem("Tools/Update Build Order")]
    private static void updateBuildOrder()//creates scene build order from enumeration
    {
        Debug.Log("updating build order");
        //get number of scenes
        int len = System.Enum.GetValues(typeof(Constants.scenes)).Length;
        Debug.Log(len);
        EditorBuildSettingsScene[] scenes = new EditorBuildSettingsScene[len];//create array of scenes
        
        foreach (string scene in System.Enum.GetNames(typeof(Constants.scenes)))//iterate through scenes
        {
            Debug.Log(scene);
            Debug.Log((int)System.Enum.Parse(typeof(Constants.scenes), scene));
            //add each scene to Scene array in proper place based on enumeration
            scenes[(int)System.Enum.Parse(typeof(Constants.scenes),scene)] = new EditorBuildSettingsScene("Assets/Scenes/" + scene + ".unity", true);

        }
        EditorBuildSettings.scenes = scenes;//set build order
    }
}