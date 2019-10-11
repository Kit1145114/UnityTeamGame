using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChenge : MonoBehaviour
{
    //Material material;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    material = (Material)Resources.Load("Asstes/Texture/kiyohara's meigen");
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetButtonDown("A"))
    //    {
    //        GetComponent<Renderer>().material = material;
    //    }
    //}

    public Material[] _material;           // 割り当てるマテリアル.
    private int i;

    // Use this for initialization
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("joystick button 0"))
        {
            i++;
            if (i == 3)
            {
                i = 0;
            }

            this.GetComponent<Renderer>().material = _material[i];
        }

    }
}
