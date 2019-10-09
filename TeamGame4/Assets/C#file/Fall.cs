using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float angle;            //回転角度
    int RotateStatu = 0;    //0 開く
                            //1 閉まる
                            //2 待機
    int timer = 0;          //待機タイマー

    // Update is called once per frame
    void Update()
    {
        //回す処理
        Quaternion qRot = gameObject.transform.rotation;
        //z軸周りに回レ！回レ！回レ！
        qRot = Quaternion.Euler(0.0f, 0.0f, angle);
        gameObject.transform.rotation = qRot;

        //回転角度によるステータスの変更
        //開ききったら「閉まる」にステータスを変更する
        if (angle > 100.0f)
        {
            RotateStatu = 1;
        }
        //閉まりきったら「待機」にステータスを変更する
        else if (angle == 0.0f)
        {
            RotateStatu = 2;
        }

        //「待機」の時、時間経過でステータスを変更
        if (RotateStatu == 2)
        {
            timer++; //タイマーを加算
            if (timer == 150)
            {
                RotateStatu = 0;    //ステータスを変更
                timer = 0;      //タイマーを初期化
            }
        }

        //ステータスが「開く」場合　開く
        if (RotateStatu == 0)
        {
            angle += 2.0f; //開く
        }
        //ステータスが「閉まる」場合　閉まる
        else if (RotateStatu == 1)
        {
            angle -= 2.0f; //閉まる
        }

    }
}
