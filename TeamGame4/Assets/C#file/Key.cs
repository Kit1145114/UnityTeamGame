using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public float MoveDown = 20.0f;
    private Vector3 KeyPos; //プレイヤー
    private bool Down = false;
    private float x;
    private float z;
    private float x2;
    private float z2;
    public float Mode = 0.3f;
    CapsuleCollider cc;
    //MeshRenderer mr;
    Vector3 position = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CapsuleCollider>();
       // mr = GetComponent<MeshRenderer>();
        KeyPos = GetComponent<Transform>().position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.PlayerDeath == false && Player2.PlayerDeath == false)
        {
            GameObject player1 = GameObject.Find("Player");
            GameObject player2 = GameObject.Find("Player2");
            Vector3 p1pos = player1.transform.position;
            Vector3 p2pos = player2.transform.position;
            float posx = (player1.transform.position.x + player2.transform.position.x) / 2;
            float posz = (player1.transform.position.z + player2.transform.position.z) / 2;
            float X = this.transform.position.x - player1.transform.position.x;
            float Z = this.transform.position.z - player1.transform.position.z;
            //カギの移動処理
            Vector3 m_position = Vector3.zero;
            m_position.x = posx;
            m_position.z = posz;
            position.y = -5.0f;
            position.x = transform.position.x;
            position.z = transform.position.z;
            if (X > Mode || X < -Mode || Z > Mode || Z < -Mode)
            {
                Down = true;
                //cc.isTrigger = true;
                //m_position.y -= 1.0f;
                //mr.enabled = false;
            }
            else
            {
                m_position.y += this.transform.position.y;
                transform.position = m_position;
            }
            if (transform.position.y <= -5.0f)
            {
                //Retry.GameRetry = true;
                Player.PlayerDeath = true;
                Player2.PlayerDeath = true;
                transform.position = position;
            }
        }
        if (Down)
        {
            cc.isTrigger = true;
        }
    }
}
