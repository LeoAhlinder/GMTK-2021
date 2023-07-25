using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevelDoor3 : MonoBehaviour
{

    public Transform DoorPos;
    public LayerMask WalkingRed;
    public LayerMask FlyingBlue;
    private bool WalkingRedDoor = false;
    private bool FlyingBlueDoor = false;

    void Update()
    {
        bool WalkingRedIsByDoor = Physics2D.OverlapCircle(DoorPos.position, 0.2f, WalkingRed);
        bool FlyingBlueIsBydoor = Physics2D.OverlapCircle(DoorPos.position, 0.2f, FlyingBlue);

        if (WalkingRedIsByDoor)
        {
            WalkingRedDoor = true;
        }
        if (FlyingBlueIsBydoor)
        {
            FlyingBlueDoor = true;
        }

        if (FlyingBlueDoor && WalkingRedDoor)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("YouFinishedText");
            }
        }
    }
}

