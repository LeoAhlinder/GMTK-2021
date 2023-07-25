using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaKillObjects : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FlyingBlue"))
        {
            GameObject.Find("FlyingBlue").GetComponent<FlyingBlue>().Health -= 100;
        }
        if (collision.gameObject.CompareTag("WalkingRed"))
        {
            GameObject.Find("WalkingRed").GetComponent<WalkingRed>().Health -= 100;
        }
    }
}
