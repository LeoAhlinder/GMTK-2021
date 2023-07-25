using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public bool RedButtonIsDestroyed = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FlyingBlue"))
        {
            gameObject.SetActive(false);
            if (gameObject.activeSelf)
            {
                RedButtonIsDestroyed = false;
            }
            if (!gameObject.activeSelf)
            {
                RedButtonIsDestroyed = true;
            }
        }
    }
}
