using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Canvas : MonoBehaviour
{
    [SerializeField] public GameObject E;
    public bool EText;
    // Update is called once per frame
    void Update()
    {
        if (EText)
        {
            E.SetActive(true);
        }
        else
        {
            E.SetActive(false);
        }

    }

}
