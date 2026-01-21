using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Crediits : MonoBehaviour
{  
    public GameObject credits ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CreditsRun());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreditsRun()
    {
        yield return new WaitForSeconds(0.5f);
        credits.SetActive(true);
        yield return new WaitForSeconds(15f);
        SceneManager.LoadScene(0);
    }
}
