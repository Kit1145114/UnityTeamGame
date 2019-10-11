using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float MoveDown = 20.0f;
    // public float gravity = -0.2f;
    private Vector3 Player_pos; //プレイヤー
    private float x;
    private float z;
    public static bool PlayerDeath;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Player_pos = GetComponent<Transform>().position;
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        PlayerDeath = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerDeath == false && Player.PlayerDeath == false)
        {
            //プレイヤー移動処理
            x = Input.GetAxis("Horizontal3");
            z = Input.GetAxis("Vertical3");

            Vector3 moveSpeed = Vector3.zero;
            Vector3 m_position = Vector3.zero;
            moveSpeed.x = x / MoveDown;
            moveSpeed.z = -(z / MoveDown);
            transform.position += moveSpeed;
            //CCon.Move(moveSpeed);
            m_position.y = -5.0f;
            m_position.x = transform.position.x;
            m_position.z = transform.position.z;
            if (gameObject.transform.position.y <= -10.0f)
            {
                transform.position = m_position;
                PlayerDeath = true;
            }
        }
        if (PlayerDeath == true)
        {
            //Retry.GameRetry = true;
            GameOver.gameOver = true;
        }
    }
}
