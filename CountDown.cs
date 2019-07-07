using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class CountDown : MonoBehaviour
{
    //the UI text that is in unity
    [SerializeField] private Text UiText;
    //stores the amount of seconds to count down
    [SerializeField] private float MainTimer;

    //the float timer that gets counted down in unity
    public float Timer;
    //is allowed to count down
    private bool CanCount = true;
    //can only count down once
    private bool DoOnce = false;


    AudioSource AS;
    public AudioClip Bell;

    void Start()
    {
        AS = GetComponent<AudioSource>();
    Timer = MainTimer;
    }

    void Update()
    {
        if(Timer >= 0.0f && CanCount)
        {
            Timer -= Time.deltaTime;
            UiText.text = Timer.ToString("0");

        }
        else if (Timer <= 0.0f && !DoOnce)
        {
            CanCount = false;
            DoOnce = true;
            UiText.text = "0.00";


        }

        if (Timer <= 0.00f)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Timer <= 5f && Timer > 0f)
        {
            AS.PlayOneShot(Bell);
            
        }
    }

}
