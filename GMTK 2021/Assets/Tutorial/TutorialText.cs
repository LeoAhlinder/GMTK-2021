using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialText : MonoBehaviour
{
    [SerializeField] public GameObject GameName;

    void Start()
    {
        GameName.SetActive(true);
        StartCoroutine(GameNameCD());
        IEnumerator GameNameCD()
        {
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Level1");
        }                
    }
}
