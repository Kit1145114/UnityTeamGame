using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player; //= GameObject.Find("Player");
    private Vector3 offset;
    //private Vector3 prevPlayerPos = new Vector3(0,0,-1);
    //private Vector3 posVector;
    //public float scale = 3.0f;
    //public float cameraSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //Vector3 currentPlayerPos = player.transform.position;
        //Vector3 backVector = (prevPlayerPos - currentPlayerPos).normalized;
        //posVector = (backVector == Vector3.zero) ? posVector : backVector;
        //Vector3 targetPos = currentPlayerPos + scale * posVector;
        //targetPos.y = targetPos.y + 0.5f;
        //gameObject.transform.position = Vector3.Lerp(
        //    gameObject.transform.position,
        //    targetPos,
        //    cameraSpeed * Time.deltaTime);
        //gameObject.transform.LookAt(player.transform.position);
        //prevPlayerPos = player.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
