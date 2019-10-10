﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour
{
    public float MoveDown = 75.0f;
    //public float gravity = -0.2f;
    public float distance = 100f;
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
        GameObject player2 = GameObject.Find("Player2");
        Vector3 p_pos = player.transform.position;
        Vector3 p2_pos = player2.transform.position;
        BoxCollider bc = gameObject.GetComponent<BoxCollider>();
        Vector3 m_pos = bc.transform.position;
        Vector3 move = Vector3.zero;
        Quaternion qRot = gameObject.transform.rotation;
        float p1 = player.transform.position.x + player.transform.position.z;
        float p2 = player2.transform.position.x + player2.transform.position.z;
        if (p1 >= p2)
        {
            move.x += (p_pos.x - m_pos.x) / MoveDown;
            move.z += (p_pos.z - m_pos.z) / MoveDown;
            Vector3 diff = transform.position - snake_pos;
            float dis = Vector3.Distance(p_pos, m_pos);
            if (dis <= distance)
            {
                gameObject.transform.position += move;
                if (dis <= 1.5f && Player.PlayerDeath == false)
                {
                    Player.PlayerDeath = true;
                }
            }
            if (diff.magnitude > 0.01f)
            {
                transform.rotation = Quaternion.LookRotation(diff);
            }
        }
        if (p1 <= p2)
        {
            move.x += (p2_pos.x - m_pos.x) / MoveDown;
            move.z += (p2_pos.z - m_pos.z) / MoveDown;
            Vector3 diff2 = transform.position - snake_pos;
            float dis2 = Vector3.Distance(p2_pos, m_pos);
            if (dis2 <= distance)
            {     
                    gameObject.transform.position += move;
                if (dis2 <= 1.5f && Player2.PlayerDeath == false)
                {
                    Player2.PlayerDeath = true;
                }
            }
            if (diff2.magnitude > 0.01f)
            {
                transform.rotation = Quaternion.LookRotation(diff2);
            }
        }
    }
}