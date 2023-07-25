using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour
{
    BlueLever bluelever;
    [SerializeField] public GameObject OpenTrapDoor;
    [SerializeField] public GameObject ClosedTrapDoor;


    private void Awake()
    {
        bluelever = GameObject.Find("FlyingBluesLever").GetComponent<BlueLever>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bluelever.BlueLeverIsUsed)
        {
            OpenTrapDoor.SetActive(true);
            ClosedTrapDoor.SetActive(false);
            StartCoroutine(TrapDoorCD());
        }

        IEnumerator TrapDoorCD()
        {
            yield return new WaitForSeconds(3.5f);
            bluelever.BlueLeverIsUsed = false;
            OpenTrapDoor.SetActive(false);
            ClosedTrapDoor.SetActive(true);
            bluelever.BlueLeverUsed.gameObject.SetActive(false);
            bluelever.gameObject.SetActive(true);
        }

    }
}
