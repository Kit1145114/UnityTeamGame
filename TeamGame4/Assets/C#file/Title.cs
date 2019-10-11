using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public AudioClip se;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //GameObject.Find("Title");
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("joystick button 0"))
        //{
        //    //SceneManager.LoadScene("SampleScene");
        //    Debug.Log("button0");
        //}
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene("Game");
            audioSource.PlayOneShot(se);
        }
    }
}