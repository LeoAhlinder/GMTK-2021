using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenescript : MonoBehaviour
{
    public bool level1 = false;
    public bool level2 = false;
    public bool level3 = false;
    void Update()
    {


        DontDestroyOnLoad(gameObject);
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Level1")
        {
            level1 = true;
        }
        if (sceneName == "Level2")
        {
            level2 = true;
        }
        if (sceneName == "Level3")
        {
            level3 = true;
        }
    }
}
