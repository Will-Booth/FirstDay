using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuController : MonoBehaviour {

    //index dictates what animation is running for which button
    // public int Index;

    //name of boolean variable being the analog stick
    // [SerializeField] bool AnalogDown;

    //highest possible index
    //[SerializeField] int MaxIndex;

    //just a standard audio source for button noises
    //public AudioSource audioSource;
    public AudioClip clip;
    AudioSource AudioData;

	// Use this for initialization
	void Start ()
    {
        //audioSource = GetComponent<AudioSource>();
        AudioData = GetComponent<AudioSource>();
        
	}

    void Update()
    {
        if (Input.GetButton("XboxA"))
        {
            ButtonAudio();
            LoadLevel();
        }

        if (Input.GetButton("XboxB")) 
        {
            ButtonAudio();
            Quit();
        }
    }


    public void LoadLevel()
    {
        SceneManager.LoadScene("Cinematic");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ButtonAudio()
    {
        
        
     AudioData.PlayOneShot(clip);
     Debug.Log("MusicGo");
        
    }
}
