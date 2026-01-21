// using UnityEngine;
// using UnityEngine.SceneManagement;
// using System.Collections;
// using System.Collections.Generic;
// using System.Xml.Serialization;

// public class MainMenu : MonoBehaviour
// {


//     public string sceneName;
//     public string creditsscene;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {   
        
//     }

//     public void StartGame()
//     {
//         SceneManager.LoadScene(sceneName);

//     }

//     public void LeaveGame()
//     {
//         Application.Quit();
//         Debug.Log("we are leaving the game");

//     }
//     public void Credits()
//     {
//         sceneManager.LoadScene(creditsscene);
//     }
// }
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
        // StartCoroutine(CreditsRun());
    }

    public void StartGame()
    {
        sceneManager.LoadScene(scenename);
    }

    public void LeaveGame()
    {
        Application.Quit();
        Debug.Log("we are leaving the game");

    }
    public void Credits()
    {
        sceneManager.LoadScene(creditsscene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
}
