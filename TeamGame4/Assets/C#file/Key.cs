using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public float MoveDown = 20.0f;
    private Vector3 KeyPos; //プレイヤー
    private float x;
    private float z;
    private float x2;
    private float z2;
    // Start is called before the first frame update
    void Start()
    {
        KeyPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject player1 = GameObject.Find("Player");
        //GameObject player2 = GameObject.Find("Player2");
        //Vector3 p1pos = player1.transform.position;
        //Vector3 p2pos = player2.transform.position;
        //float posx = (player1.transform.position.x + player2.transform.position.x) / 2;
        //float posz = (player1.transform.position.z + player2.transform.position.z) / 2;
        //カギの移動処理
        x = Input.GetAxis("Horizontal");
        x2 = Input.GetAxis("Horizontal3");
        z = Input.GetAxis("Vertical");
        z2 = Input.GetAxis("Vertical3");
        if (x != 0.0f || z != 0.0f)
        {
            Vector3 moveSpeed = Vector3.zero;
            moveSpeed.x = (x) / MoveDown;
            moveSpeed.z = -(z) / MoveDown;
            transform.position += moveSpeed;
        }
        else if (x2 != 0.0f || z2 != 0.0f)
        { Vector3 moveSpeed2 = Vector3.zero;
            moveSpeed2.x = (x2) / MoveDown;
            moveSpeed2.z = -(z2) / MoveDown;
            transform.position += moveSpeed2;
        }
        //Vector3 m_position = Vector3.zero;
        //m_position.x = x;
        //m_position.z = z;
        //m_position.y = 1.2f;
        //transform.position = m_position;
        if (transform.position.y < -10.0f)
        {
            Retry.GameRetry = true;
        }
    }
}
