using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fininshed : MonoBehaviour
{
    public float TimesFininshed = 0f;
    void Update()
    {
        DontDestroyOnLoad(gameObject);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("321");
            SceneManager.LoadScene("Level1");
            TimesFininshed += 1.3f;
        }
    }
}
