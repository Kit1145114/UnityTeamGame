using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyPut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 p_pos = player.transform.position;
        Vector3 k_pos = gameObject.transform.position;
        float dis = Vector3.Distance(p_pos, k_pos);
        if (dis <= 0.5f)
        {
            Game.GameCrear = true;
        }
    }

    //private static Vector3 NewMethod(GameObject player)
    //{
    //    return player.transform.localPosition;
    //}
}
