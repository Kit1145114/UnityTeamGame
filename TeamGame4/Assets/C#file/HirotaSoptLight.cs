using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HirotaSoptLight : MonoBehaviour
{
    private bool SwichLight = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            SwichLight = true;
        }
        if (other.gameObject.name == "Player2")
        {
            SwichLight = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj = GameObject.Find("HirotaLight");
        Color c = obj.GetComponent<Light>().color;

        if(SwichLight == true)
        {
            c = Color.white;
            obj.GetComponent<Light>().color = c;
        }
    }
}
