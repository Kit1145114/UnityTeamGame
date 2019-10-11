using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHit : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "MoveFloor")
        {
            transform.parent = col.gameObject.transform;

        }
    }
    void OnTriggerExit()
    {
        transform.parent = null;
       
    }
}
