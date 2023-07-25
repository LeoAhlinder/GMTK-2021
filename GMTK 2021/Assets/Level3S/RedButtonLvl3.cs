using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButtonLvl3 : MonoBehaviour
{
    [SerializeField] public GameObject UsedRedButton;
    [SerializeField] public GameObject Trapdoor1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FlyingBlue"))
        {
            gameObject.SetActive(false);
            UsedRedButton.SetActive(true);
            Trapdoor1.transform.position = new Vector3(36.97328f, -1.6f, 0);
            
        }
    }
}
