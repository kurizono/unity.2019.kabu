using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winlose : MonoBehaviour {
    opning opningcs;
    quizbook quizbookcs;
    setting settingcs;

    int choice0 = 0;                                      //選択肢について(一度きり)
    int choice = 0;                                       //選択肢について    
    public int win = 0;                                        //正解した回数s
    int mark = 0;                                       //〇×表示を管理する
    int marktime = 0;

    public GameObject Frame;                            //枠組み生成
    Vector3 frame;
    public GameObject Judge;                               //〇×生成
    Vector3 judge;


    // Use this for initialization
    void Start () {
        opningcs = GetComponent<opning>();
        settingcs = GetComponent<setting>();
        quizbookcs = GetComponent<quizbook>();

        frame = new Vector3(100, 3.75f, 0);             //枠組みの位置
        Frame.transform.position = frame;               //枠組みの位置を代入(最初はカメラの範囲外に)
        judge = new Vector3(50, 50, 0);                 //〇×の位置
        Judge.transform.position = judge;               //〇×の位置(最初は両方とも見えないように)
    }

    // Update is called once per frame
    void Update () {
        if (opningcs.op == 1 && choice0 == 0)                           //opが終わって選択肢が出てないとき
        {
            choice0 = 1;                                                //繰り返さないため
            choice = 1;                                                 //選択肢が一番上の状態
        }
        if (choice0 == 1)                                               //選択肢を自由に動かせるとき
        {
            if (Input.GetKeyDown("up"))                                 //上矢印押した時
            {
                choice = choice - 1;                                    //choiceを1マイナスする
            }
            if (Input.GetKeyDown("down"))                               //下矢印を押した時
            {
                choice = choice + 1;                                    //choiceを1プラスする
            }
            choice = (choice + 3) % 3;                                    //choiceを3で割った余り
            switch (choice)
            {
                case 1:                                                 //一番上を選択
                    frame = new Vector3(0, 3.65f, -1);                  //枠の位置を設定
                    Frame.transform.position = frame;
                    break;
                case 2:                                                 //真ん中を選択
                    frame = new Vector3(0, 1.1f, -1);                   //枠の位置を設定
                    Frame.transform.position = frame;
                    break;
                case 0:                                                 //一番下を選択
                    frame = new Vector3(0, -1.4f, -1);                  //枠の位置を設定
                    Frame.transform.position = frame;
                    break;
            }
            //上矢印で上の選択肢に移動・下矢印で下の選択肢に移動

            if (Input.GetKeyDown(KeyCode.Z))                            //Zを押した時
            {
                if (choice == quizbookcs.answer)                        //答えが正しければ
                {
                    win = win + 1;                                      //winの値を増やす
                    mark = mark + 1;                                    
                }
                mark = mark + 1;                                        //正解の時はmark=2,間違いの時はmark=1
            }
        }
        //Zキーで選択
        //answerを選んだらwinに＋1 mark＝1、選ばなかったらmark＝2

        if (settingcs.quiznum < 4)                                          //クイズを行っている最中だけ実行
        {
            if (mark == 1 || mark == 2)                                     //正解or間違いの時
            {                                                               
                marktime = marktime + 1;                                    //時間計測開始
                if (marktime == 1)                                          //一回だけ処理
                {
                    if (mark == 1)                                          //間違いの時
                    {
                        judge = new Vector3(100, 100, 0);                   //×が見えるように
                        Judge.transform.position = judge;
                    }
                    if (mark == 2)                                          //正解の時
                    {
                        judge = new Vector3(0, 0, 0);                       //〇が見えるように
                        Judge.transform.position = judge;
                    }
                }
                if (marktime == 60)                                             //1秒計測した結果
                {

                    judge = new Vector3(50, 50, 0);                             //元の位置に戻す
                    Judge.transform.position = judge;
                    mark = 0;                                                   //正誤判定初期化
                    marktime = 0;                                               //計測時間初期化
                    settingcs.quiznum = settingcs.quiznum + 1;                  //次の問題に向かう
     
                }
            }
        }
        //1秒間〇×を見せてから(judgeで位置調整)次の問題に向かう。

    }
}
