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
        MeshCollider mesh = gameObject.GetComponent<MeshCollider>();
        Vector3 p_pos = player.transform.position;
        Vector3 k_pos = transform.position;
        float dis = Vector3.Distance(p_pos, k_pos);
        if(dis <= 1.5f)
        {
            Game.GameCrear = true;
            Debug.Log("草");
        }
    }
}
