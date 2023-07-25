using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //GameObjects
    [SerializeField] public GameObject StartMenu;
    [SerializeField] public GameObject PauseMenu;
    [SerializeField] public GameObject DeathScreen;

    //Bools
    WalkingRed walkingred;
    FlyingBlue flyingblue;

    //RandomStuff
    public float TimesRespawned = 0;


    private void Start()
    {
        if (TimesRespawned == 0)
        {
            StartMenu.SetActive(true);
        }
    }

    private void Awake()
    {
        flyingblue = GameObject.Find("FlyingBlue").GetComponent<FlyingBlue>();
        walkingred = GameObject.Find("WalkingRed").GetComponent<WalkingRed>();
    }
    public void StartBut()
    {
        PauseMenu.SetActive(false);
       StartMenu.SetActive(false);
        DeathScreen.SetActive(false);
    }
    public void Quit()
    {
       Application.Quit();
    }
    public void Continue()
    {
        PauseMenu.SetActive(false);
    }
    public void Respawn()
    {        
        SceneManager.LoadScene("Level1");
        walkingred.transform.position = new Vector3(0f, 0, 0);
        flyingblue.transform.position = new Vector3(1f, 0, 0);
        walkingred.Health = 5f;
        flyingblue.Health = 1f;
        Destroy(flyingblue.gameObject);
        Destroy(walkingred.gameObject);
        DeathScreen.SetActive(false);
        StartMenu.SetActive(false);
        TimesRespawned += 1;
    }


    private void Update()
    {
        if (StartMenu.activeSelf || PauseMenu.activeSelf || DeathScreen.activeSelf)
        {
            walkingred.Freeze = true;
            Time.timeScale = 0;
        }
        else
        {
            walkingred.Freeze = false;
            Time.timeScale = 1;
        }

        if (PauseMenu.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                PauseMenu.SetActive(false);
            }
        }
        if (!PauseMenu.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                PauseMenu.SetActive(true);
            }
        }

        if (walkingred.Health <= 0)
        {
            walkingred.gameObject.SetActive(false);
            DeathScreen.SetActive(true);
        }

        if (flyingblue.Health <= 0)
        {
            flyingblue.gameObject.SetActive(false);
            DeathScreen.SetActive(true);
        }
    }
}
