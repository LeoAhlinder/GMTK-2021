using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    RedButton redbutton;
    private void Awake()
    {
        redbutton = GameObject.Find("RedButton_0").GetComponent<RedButton>();
    }
    // Update is called once per frame
    public void Update()
    {
        if (redbutton.RedButtonIsDestroyed)
        {
            Destroy(gameObject);
        }
    }
}
