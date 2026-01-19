using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
public class LevelController : MonoBehaviour
{
    //here we we have declared collection of enemies(birds) in enemy script 
    private Enemy[] birds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    private void OnEnable()
    {
        //birds array will have all the enemies in the scene
        birds = FindObjectsOfType<Enemy>();
    }
   
    // Update is called once per frame
    void Update()

    {
        if (BirdsAreDead())
        {
            GoNextLevel();
        }
    }

//basically we are knowing the birds are dead or not
    private bool BirdsAreDead()
    {
      foreach(var enemy in birds)
        {
            if (enemy.gameObject.activeSelf)
            {
                return false;
            }
        }
        return true;
        // here if any enemy left then return false and if all dead return true
   
    }

    private void GoNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
