using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //we have defined an arrray for all the sounds 
    public AudioSource[] soundEffects;

//this is done to make the script accessible in different scripts
    public static AudioManager instance;

    public void Awake()
    {
        instance=this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //small function to play the audio
    public void Playfx(int soundtoplay)
    {
        soundEffects[soundtoplay].Play();
    }
}
