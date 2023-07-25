using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingRed : MonoBehaviour
{
    public float speed = 2f;
    public float Health = 5f;
    public bool Freeze;
    Fininshed F;

    private void Awake()
    {
        F = GameObject.Find("Fininshed").GetComponent<Fininshed>();
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {

        if (!Freeze)
        {
            if (F.TimesFininshed == 0)
            {
                Vector3 movement = new Vector3(Input.GetAxis("Arrows"), 0f, 0f);
                transform.position += movement * Time.deltaTime * speed;
            }
            else
            { 
            Vector3 movement = new Vector3(Input.GetAxis("Arrows"), 0f, 0f);
            transform.position += movement * Time.deltaTime * speed * F.TimesFininshed;
            }

            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
