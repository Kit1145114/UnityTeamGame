﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorHit : MonoBehaviour
{
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "MoveFloor")
        {
            transform.parent = col.gameObject.transform;
            Debug.Log("parenting");
        }
    }
    void OnCollisionExit()
    {
        transform.parent = null;
        Debug.Log("exit");
    }
}
