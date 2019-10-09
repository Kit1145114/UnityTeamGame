using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{

    private Vector3 StonePos; //岩の座標  

    // Start is called before the first frame update
    void Start()
    { 
    }


    // Update is called once per frame
    void Update()
    {
        //岩の座標を持ってくる
        StonePos = GetComponent<Transform>().position;
        //Yが-50以下になったら
        if (StonePos.y <= -50.0f)
        {
            //初期位置に戻す
            StonePos = new Vector3(0.04f, 5.48f, 37.86f);
            transform.position = StonePos;
        }
    }
}
