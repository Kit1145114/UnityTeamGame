using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private int Back = 0;         //0 前進
                                  //1 後退
                                  //2 待機

    private int Com_Back = 0;     //0 前進
                                  //1 後退

    private Vector3 FloorPos;     //動く床の座標
    private Vector3 PlayerPos;
    private int timer = 0;        //タイマー
    private int taikitimer = 0;   //待機タイマー
    private bool one = false;
    

    // Update is called once per frame
    void Update()
    {
        //動く床の座標を持ってくる
        FloorPos = GetComponent<Transform>().position;

        //動かす処理
        timer++;　//タイマー加算
        if(timer > 230)
        {
            if (one == false)
            {
                Com_Back = Back;    //状態を補完する
                one = true;
            }
            Back = 2;           //一時待機
            taikitimer++;          //待機タイマー加算
            if (taikitimer == 60)
            {
                //Com_Backが1なら
                if (Com_Back == 1)
                {
                    Back = 0;
                    //初期化
                    timer = 0;
                    taikitimer = 0;
                    one = false;
                }
                //Com_Backが0なら
                else if (Com_Back == 0)
                {
                    Back = 1;
                    //初期化
                    timer = 0;
                    taikitimer = 0;
                    one = false;
                }
            }
        }

        //バックが0なら
        if (Back == 0)
        {
            //前に進める
            FloorPos.z += 0.01f;
        }
        //バックが1なら
        else if(Back == 1)
        { 
            //後ろに進める
            FloorPos.z -= 0.01f;
        }
        //代入する
        transform.position = FloorPos;
    }
}
