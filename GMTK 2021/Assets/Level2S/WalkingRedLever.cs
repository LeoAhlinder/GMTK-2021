using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingRedLever : MonoBehaviour
{
    public Transform LeverPos;
    public LayerMask WalkingRed;
    public GameObject OpenedTrapDoor;
    public GameObject DraggedLever;
    public GameObject ClosedTrapDoor;
    public GameObject SecondTrapDoor;
    void Update()
    {
        bool WalkingRedIsClose = Physics2D.OverlapCircle(LeverPos.position, 0.4f, WalkingRed);
        
        if (WalkingRedIsClose)
        {
            if (Input.GetKey("e"))
            {
                SecondTrapDoor.SetActive(false);
                OpenedTrapDoor.SetActive(true);
                ClosedTrapDoor.SetActive(false);
                DraggedLever.SetActive(true);
                gameObject.SetActive(false);
            }
        }

    }
}
