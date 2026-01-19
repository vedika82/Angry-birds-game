using UnityEngine;
using System.Collections;
// using System.Collections.Generic;
// using System.Threading.Tasks.Dataflow;
// using System.Collections.ObjectModel;
// using System.Numerics;
using UnityEngine.SceneManagement;
// using System.Diagnostics;


public class Enemy : MonoBehaviour
{
    public GameObject impact;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


//during collison from a specific object the enemy will die 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //added impact effect when enemy dies
            Instantiate(impact, transform.position,Quaternion.identity);
            Destroy(gameObject);
            Debug.Log("Enemy died");
            // gameObject.SetActive(false);

            //to go to the next level when the enemy dies 
            // SceneManager.LoadScene(1);
            //the above have a problem
            //will always load the scene with index 1
            //therefore update version below
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //this only works on one enemy only bc when one killed the scene reloads and other enemies are lost
            // thats why we use level controller script
        }

        else if (collision.gameObject.CompareTag("Box"))
        {
            // Destroy(gameObject);
            ContactPoint2D contactPoint = collision.contacts[0];
            if (contactPoint.normal.y < -0.5f)//just taken normal as y cause we need to hurt the enemy vertically
            {  
                Instantiate(impact , transform.position,Quaternion.identity);
                gameObject.SetActive(false);
                 Debug.Log("Enemy died");
                //  SceneManager.LoadScene(1);
                 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
