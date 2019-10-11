using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultTime : MonoBehaviour
{
    private int highScore;
    public static int result;
    public Text resultTime;
    //public Text bestTime;
    //public GameObject resultUI;

    // Start is called before the first frame update
    void Start()
    {
      //if(PlayerPrefs.HasKey("HighScore"))
      //  {
      //      highScore = PlayerPrefs.GetInt("HighScore");
      //  }
      //  else
      //  {
      //      highScore = 999;
      //  }
    }

    // Update is called once per frame
    void Update()
    {
        //resultUI.SetActive(true);
        //int result = Mathf.FloorToInt(Timer.time);
        resultTime.text = "ResultTime:" + result;
      //  bestTime.text = "BestTime:" + bestTime;
        //if(highScore > result)
        //{
        //    PlayerPrefs.SetInt("HighScore", result);
        //}
    }
}
