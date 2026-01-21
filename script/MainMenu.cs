
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

public class MainMenu : MonoBehaviour
{  
    public string scenename;
    public string creditsscene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public void StartGame()
    {
        SceneManager.LoadScene(scenename);
    }

    public void LeaveGame()
    {
        Application.Quit();
        Debug.Log("we are leaving the game");

    }
    public void Credits()
    {
        SceneManager.LoadScene(creditsscene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
}
