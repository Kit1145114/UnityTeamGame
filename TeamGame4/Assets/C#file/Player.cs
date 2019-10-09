using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveDown = 20.0f;
    public float gravity = -0.2f;
    private Vector3 Player_pos; //プレイヤー
    private float x;
    private float z;

    CharacterController CCon;

    // Start is called before the first frame update
    void Start()
    {
        Player_pos = GetComponent<Transform>().position;
        CCon = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤー移動処理
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 moveSpeed = Vector3.zero;
        moveSpeed.x = x / MoveDown;
        moveSpeed.z = z / MoveDown;
        moveSpeed.y = gravity;

        CCon.Move(moveSpeed);
    }
}
