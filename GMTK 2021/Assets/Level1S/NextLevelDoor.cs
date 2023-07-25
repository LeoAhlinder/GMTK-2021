using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelDoor : MonoBehaviour
{
    public Transform DoorPos;
    public LayerMask WalkingRed;
    public LayerMask FlyingBlue;
    private bool WalkingRedDoor = false;
    private bool FlyingBlueDoor = false;
    Level1Canvas level1canvas;
    
    // Update is called once per frame
    private void Awake()
    {
        level1canvas = GameObject.Find("Level1Canvas").GetComponent<Level1Canvas>();
    }
    void Update()
    {
        bool WalkingRedIsByDoor = Physics2D.OverlapCircle(DoorPos.position, 1f, WalkingRed);
        bool FlyingBlueIsBydoor = Physics2D.OverlapCircle(DoorPos.position, 1f, FlyingBlue);

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

            level1canvas.EText = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Level2");
                level1canvas.EText = false;
            }
        }
    }
}
