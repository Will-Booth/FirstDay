using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class EndMenuController : MonoBehaviour {

    AudioSource AS;
    public AudioClip  buttonPress;
    public GameObject FriendText;
    public GameObject FoeText;
    public GameObject AText;
    public GameObject BText;
    public GameObject YText;
    public GameObject CryText;

    public Text friendText,foeText,cryText;
    
    private EndGame condition;

	// Use this for initialization
	void Start ()
    {
        AS = GetComponent<AudioSource>();
        AText.SetActive(true);
        BText.SetActive(false);
        YText.SetActive(false);
        FriendText.SetActive(false);
        FoeText.SetActive(false);
        CryText.SetActive(false);
        friendText.text = "";
        foeText.text = "";
        cryText.text = "";
    
        condition = FindObjectOfType<EndGame>();
        
    
	}



    void Update()
    {
        if (Input.GetButton("XboxA"))
        {
            Debug.Log("First");
            FriendText.SetActive(true);
            FoeText.SetActive(true);
            CryText.SetActive(true);
            setMenuText();
            //put friends and foe stats code here
            AText.SetActive(false);
            BText.SetActive(true);
            YText.SetActive(true);
            AS.PlayOneShot(buttonPress);
        }

        if(Input.GetButton("XboxB"))
        {
            AS.PlayOneShot(buttonPress);
            Application.Quit();
        }

        if (Input.GetButton("XboxY"))
        {
            AS.PlayOneShot(buttonPress);
            Destroy(condition.gameObject);
            SceneManager.LoadScene("MainMenu");
        }

    }
    private void setMenuText()
    {
        friendText.text = condition.friends.ToString() + " Friends!";
        foeText.text = condition.amountLeft.ToString() + " foes!";
        cryText.text = condition.amountCry.ToString() + " Cry Babies!";
    }
    

    

}
