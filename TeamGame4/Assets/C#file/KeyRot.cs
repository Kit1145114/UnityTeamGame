using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRot : MonoBehaviour
{

    public GameObject lookTarget; //向くオブジェクト

    public float RotSpeed;  //向くスピード

    void Update()
    {
       if (lookTarget)
        {
            Quaternion lockRotation = Quaternion.LookRotation(lookTarget.transform.position - transform.position, Vector3.up);

            lockRotation.x = 0;
            lockRotation.z = 0;

            transform.rotation = Quaternion.Lerp(transform.rotation, lockRotation, RotSpeed);
        }
    }
}
