using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{

    private Vector3 StonePos; //岩の座標  
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //SphereCollider sc = GetComponent<SphereCollider>();
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Player.PlayerDeath == false && Player2.PlayerDeath == false)
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
        else
        {
            rb.isKinematic = true;
        }
    }
}
