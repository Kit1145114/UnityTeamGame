using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    float sight_x = 0;
    float sight_y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") / 20.0f;
        float z = Input.GetAxis("Vertical") / 20.0f;
        float angleH = Input.GetAxis("Horizontal2") * 5.0f;
        float angleV = Input.GetAxis("Vertical2") * 5.0f;
        if (sight_x >= 360)
        {
            sight_x = sight_x - 360;
        }
        else if(sight_x < 0)
        {
            sight_x = 360 - sight_x;
        }
        sight_x = sight_x + angleH;

        if (sight_y > 80)
        {
            if(angleV < 0)
            {
                sight_y = sight_y + angleV;
            }
        }
        else if(sight_y < -90)
        {
            if(angleV > 0)
            {
                sight_y = sight_y + angleV;
            }
        }
        else
        {
            sight_y = sight_y + angleV;
        }
        transform.localRotation = Quaternion.Euler(sight_y, sight_x, 0);
        float dx = Mathf.Sin(sight_x * Mathf.Deg2Rad) * z + Mathf.Sin((sight_x + 90f) * Mathf.Deg2Rad) * x;
        float dz = Mathf.Cos(sight_x * Mathf.Deg2Rad) * z + Mathf.Cos((sight_x + 90f) * Mathf.Deg2Rad) * x;
        transform.Translate(dx, 0, dz, 0.0f);
        transform.localRotation = Quaternion.Euler(sight_y, sight_x, 0);
    }
}
