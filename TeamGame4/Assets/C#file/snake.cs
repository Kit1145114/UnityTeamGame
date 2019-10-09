using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour
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
        MeshCollider mesh = gameObject.GetComponent<MeshCollider>();
        Vector3 m_pos = mesh.transform.position;
        float dis = Vector3.Distance(p_pos,m_pos);
        if(dis < 50.0f)
        {
            gameObject.transform.position += (player.transform.position / 10);
        }
        else
        {
            //float Timer = Time.deltaTime;
        }
    }
}
