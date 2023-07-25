using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverLvl3 : MonoBehaviour
{

    [SerializeField] public LayerMask FlyingBlue;
    [SerializeField] public GameObject UsedLever;
    [SerializeField] public GameObject Lever;
    [SerializeField] public GameObject TrapDoor2;
    [SerializeField] public Transform LeverPos;


    void Update()
    {
        bool CloseToLever = Physics2D.OverlapCircle(LeverPos.position, 0.5f, FlyingBlue);

        if (CloseToLever)
        {
            if (Input.GetKey("e"))
            {
                Lever.SetActive(false);
                UsedLever.SetActive(true);
                if (TrapDoor2.transform.position.y > -1.61)
                {
                    TrapDoor2.transform.Translate(0, -Time.deltaTime, 0);
                }
            }
        }


    }
}
