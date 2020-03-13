using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class opning : MonoBehaviour
{

    public GameObject newcamera;                        //カメラを生成
    public GameObject okinakabunuketa;                  //おきなかぶぬけた生成
    public GameObject kakegoe;                          //掛け声生成
    public GameObject rule;                             //ルール説明生成
    float timewatch;                                   //タイムウォッチを生成
    Vector3 Maincamera;                             //カメラの座標生成         
    Vector3 kabunuketa;                             //おきなかぶぬけた座標生成
    Vector3 ruru;                                   //ルール説明座標生成

    int de;                                             //debag用のなにか
    public int op = 0;                                   //opningなどの状況を伝えるやつ
   
    // Use this for initialization
    void Start()
    {
        Maincamera = new Vector3(-8, 0.5f, -5);         //最初のカメラの位置
        newcamera.transform.position = Maincamera;      //カメラの位置を代入(うんとこしょが見えるように)
        kabunuketa = new Vector3(10, 10, 10);           //おきなかぶぬけた位置
        okinakabunuketa.transform.position = kabunuketa;//おきなかぶぬけたの位置を代入(最初はカメラの範囲外に)
        ruru = new Vector3(1020, 0, 0);      //ルール説明の位置(最初はカメラの範囲外に)		
    }

    // Update is called once per frame
    void Update()
    {
        timewatch = timewatch + 1;                      //タイムウォッチで時間計る
        if (op == 0)
        {
            if (timewatch == 90)
            {
                Maincamera = new Vector3(8, 0.5f, -5);      //1.5秒のカメラの位置
                newcamera.transform.position = Maincamera;  //カメラの位置を代入(どっこいしょが見えるように)
            }
            if (timewatch == 180)
            {
                Maincamera = new Vector3(0, 0, -2);         //3.0秒のカメラの位置
                newcamera.transform.position = Maincamera;  //カメラの位置を代入(株メイン)
                kabunuketa = new Vector3(0, -2.5f, 8);          //おきなかぶぬけたの位置
                okinakabunuketa.transform.position = kabunuketa;    //おきなかぶぬけたの位置を代入
            }
            if (timewatch > 180 && timewatch <= 360)
            {
                Maincamera.y = Maincamera.y + 0.01388889f;                                            //Maincameraを(0,2.5,-10)に近づける
                Maincamera.z = Maincamera.z - 0.044444444444444f;
                newcamera.transform.position = Maincamera;
                rule.transform.position = ruru;
            }
            if (timewatch > 360 && timewatch <= 600)
            {
                ruru.x = ruru.x - 5.833333333333333333f;                    //ルール説明を(0，0，0)に近づける
                ruru.y = 188;
                rule.transform.position = ruru;
            }
            if (timewatch == 660)
            {
                kabunuketa = new Vector3(100, 100, 0);                  //邪魔な文字をどける
                okinakabunuketa.transform.position = kabunuketa;
                kakegoe.transform.position = kabunuketa;
                op = 1;                                                 //opを1にする
            }
        }
    }
}
        //ここまでop。ここから本編。opを1に設定。
        