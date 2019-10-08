using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Move = 3.0f;
    CharacterController CCon;
    // Start is called before the first frame update
    void Start()
    {
        CCon = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤー移動処理
     
    }
}
