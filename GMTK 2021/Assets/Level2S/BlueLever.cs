using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLever : MonoBehaviour
{
    [SerializeField] public Transform BlueLeverpos;
    [SerializeField] public LayerMask FlyingBlue;
    [SerializeField] public GameObject BlueLeverUsed;
    public bool BlueLeverIsUsed = false;
    // Update is called once per frame
    void Update()
    {
        bool BlueCloseToLever = Physics2D.OverlapCircle(BlueLeverpos.position, 0.4f, FlyingBlue);

        if (BlueCloseToLever)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                gameObject.SetActive(false);
                BlueLeverUsed.SetActive(true);
                BlueLeverIsUsed = true;
            }
        }
    }
}