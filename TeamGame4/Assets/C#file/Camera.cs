using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player; //= GameObject.Find("Player");
    public float rotateSpeed = 3.0f;
    private Vector3 offset;
    Vector3 targetPos;
    float sight_x = 0;
    float sight_y = 0;
    void Start()
    {
        offset = transform.position - player.transform.position;
        targetPos = player.transform.position;
    }
    // Update is called once per frame
    void Camera1()
    {
        //float angleH = Input.GetAxis("Horizontal2") * 5.0f;
        //float angleV = Input.GetAxis("Vertical2") * 5.0f;
        //if (sight_x >= 360)
        //{
        //    sight_x = sight_x - 360;
        //}
        //else if (sight_x < 0)
        //{
        //    sight_x = 360 - sight_x;
        //}
        //sight_x = sight_x + angleH;

        //if (sight_y > 80)
        //{
        //    if (angleV < 0)
        //    {
        //        sight_y = sight_y + angleV;
        //    }
        //}
        //else if (sight_y < -90)
        //{
        //    if (angleV > 0)
        //    {
        //        sight_y = sight_y + angleV;
        //    }
        //}
        //else
        //{
        //    sight_y = sight_y + angleV;
        //}
        transform.position = player.transform.position + offset;
        //transform.localRotation = Quaternion.Euler(sight_y, sight_x, 0);
    }

    void Camera2()
    {
    float angle = Input.GetAxis("Horizontal2") * rotateSpeed;
    transform.position = player.transform.position + offset;
    transform.RotateAround(transform.position, Vector3.up, angle);
    }

    void Camera3()
    {
        float angle = Input.GetAxis("Horizontal2") * rotateSpeed;
        transform.position = player.transform.position + targetPos;
        transform.RotateAround(targetPos, Vector3.up, angle);
    }
    void Update()
    {
        Camera1();
        //Camera2();
        //Camera3();
    }
    private void LateUpdate()
    {
        //transform.position = player.transform.position + offset;
    }
}
