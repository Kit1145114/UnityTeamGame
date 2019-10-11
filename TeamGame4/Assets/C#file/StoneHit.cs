using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //衝突したオブジェクトの名前がPlayerなら
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("潰されました");
        }
        //衝突したオブジェクトの名前がPlayer2なら
        if (collision.gameObject.name == "Player2")
        {
            Debug.Log("2潰されました");
        }

        //衝突したオブジェクトの名前がKeyなら
        if (collision.gameObject.name == "Keys")
        {
            Debug.Log("カギが壊れました");
        }
    }
}
