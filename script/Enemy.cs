using UnityEngine;
using System.Collections;
// using System.Collections.Generic;
// using System.Threading.Tasks.Dataflow;
// using System.Collections.ObjectModel;
using System.Numerics;

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
            Instantiate(impact , transform.position,Quaternion.identity);
            Destroy(gameObject);
            // gameObject.SetActive(false);
        }

        else if (collision.gameObject.CompareTag("Box"))
        {
            // Destroy(gameObject);
            ContactPoint2D contactPoint = collision.contacts[0];
            if (contactPoint.normal.y < -0.5f)//just taken normal as y cause we need to hurt the enemy vertically
            {  
                Instantiate(impact , transform.position,Quaternion.identity);
                gameObject.SetActive(false);
            }
        }
    }
}
