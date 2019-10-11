using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public AudioClip se2;
    AudioSource audioSource;
    public static bool GameCrear; 
    // Start is called before the first frame update
    void Start()
    {
        GameCrear = true;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene("Title");
            audioSource.PlayOneShot(se2);
        }
    }
}
