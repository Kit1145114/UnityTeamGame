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
        StonePos = GetComponent<Transform>().position;
        if (StonePos.y <= -50.0f)
        {
            StonePos = new Vector3(0.04f, 5.48f, 32.95f);
            transform.position = StonePos;
        }
    }
}
