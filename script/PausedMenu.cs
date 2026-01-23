using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

public class PausedMenu : MonoBehaviour
{

    public GameObject pauseScreen;
    private bool isPaused;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//to use the pause and unpause on any mechanic we can use escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        //we during playing the player is stopped
            Time.timeScale = 1f;

    }

    public void PauseUnpause()
    {//done this cause we need to know whether the screen is paused or not 
        if(isPaused )
        {
            isPaused=false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
        }

        else
        {
            isPaused= true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }



}
