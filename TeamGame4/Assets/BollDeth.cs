﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollDeth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        /*Debug.Log("衝突したオブジェクト：" + gameObject.name);
        Debug.Log("衝突されたオブジェクト：" + collision.gameObject.name);
        */
        Destroy(this.gameObject, 0.5f);

    }
}
