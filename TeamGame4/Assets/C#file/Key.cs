using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public float MoveDown = 20.0f;
    private Vector3 KeyPos; //プレイヤー
    private float x;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        KeyPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        //カギの移動処理
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 moveSpeed = Vector3.zero;
        moveSpeed.x = x / MoveDown;
        moveSpeed.z = z / MoveDown;
        transform.position += moveSpeed;
    }
}
