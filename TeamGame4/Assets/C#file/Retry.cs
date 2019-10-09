using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public static bool GameRetry; 
    // Start is called before the first frame update
    void Start()
    {
        GameRetry = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameRetry == true)
        {
            //のちにゲームオーバー画面に。今は強制リトライ。
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
        }
    }
}
