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
        GameObject player1 = GameObject.Find("Player");
        GameObject player2 = GameObject.Find("Player2");
        Vector3 p1pos = player1.transform.position;
        Vector3 p2pos = player2.transform.position;
        float posx = (player1.transform.position.x + player2.transform.position.x) / 2;
        float posz = (player1.transform.position.z + player2.transform.position.z) / 2;
        float A = posx + posz;
        //カギの移動処理
        Vector3 m_position = Vector3.zero;
        m_position.x = posx;
        m_position.z = posz;
        
        m_position.y += transform.position.y;
        transform.position = m_position;
        if (transform.position.y < -10.0f)
        {
            Retry.GameRetry = true;
        }
    }
}
