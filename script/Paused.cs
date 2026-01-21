using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;


public class Paused : MonoBehaviour
{

    public GameObject pauseScene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUppause();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseUnpause()
    {//done this cause we need to know whether the screen is paused or not 
        if(ispaused )
        {
            ispaused=false;
            pauseScreen.SetActive(false);
        }

        else
        {
            ispaused= true;
            pauseScreen.SetActive(true);
        }
    }



}
