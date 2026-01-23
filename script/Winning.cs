using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Reflection;
using System.Diagnostics;


public class Winning : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void leavegame()
    {
        Application.Quit();
        Debug.Log("we are leaving the game");
        
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
