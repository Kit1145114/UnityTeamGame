using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static bool GameCrear;
    // Start is called before the first frame update
    void Start()
    {
        GameCrear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameCrear == true)
        {
            SceneManager.LoadScene("Result");
        }
    }
}
