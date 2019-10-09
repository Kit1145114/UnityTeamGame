using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour
{
    public float MoveDown = 100.0f;
    public float gravity = -0.2f;
    public float distance = 3.5f;
    private Vector3 snake_pos;
    // Start is called before the first frame update
    void Start()
    {
        snake_pos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 p_pos = player.transform.position;
        MeshCollider mesh = gameObject.GetComponent<MeshCollider>();
        Vector3 m_pos = mesh.transform.position;
        Vector3 move = Vector3.zero;
        Quaternion qRot = gameObject.transform.rotation;
        move.x += (p_pos.x - m_pos.x) / MoveDown;
        move.z += (p_pos.z - m_pos.z) / MoveDown;

        Vector3 diff = transform.position - snake_pos;
        float dis = Vector3.Distance(p_pos,m_pos);
        if(dis <= distance)
        {
            gameObject.transform.position += move;
            if (dis <= 2.0f && Player.PlayerDeath == false )
            {
                Player.PlayerDeath = true;
            }
        }
        else
        {
            //float Timer = Time.deltaTime;
        }
        if(diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff);
        }
    }
}
