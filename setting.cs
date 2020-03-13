using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour {

    opning opningcs;                                       //opningから参照   
    quizbook quizbookcs;                                    //quizbookから参照

    public int quiznow = 0;                             //今の問題
    public int quiznum, quiznum1, quiznum2, quiznum3 = 0;  //クイズ番号
    int de = 0;

    // Use this for initialization
    void Start () {
        opningcs = GetComponent<opning>();
        quizbookcs = GetComponent<quizbook>();
    }

    // Update is called once per frame
    void Update()
    {

        while (quiznum == 0)
        {                                                //クイズを設定
            quiznum1 = Random.Range(1, 13);                            //1から13までの数字をランダムに生成
            quiznum2 = Random.Range(1, 13);                            //1から13までの数字をランダムに生成
            quiznum3 = Random.Range(1, 13);                            //1から13までの数字をランダムに生成
            quiznum = 1;
            if (quiznum1 == quiznum2 || quiznum1 == quiznum3)
            {                                                           //全部のクイズが違うものになるように設定
                quiznum = 0;
            }
        }                                                               //クイズが決まったら quiznum=1 になる
                                                                        //quiznum〇＝a でクイズナンバー決定。決まったらquiznum＝1になる。



        if (opningcs.op == 1 && quiznum == 1)                            //オープニングが終わる＆quizが決定したら…
        {
            quiznow = quiznum1;                                         //クイズ番号はquiznum1                                           
        }                                                               //クイズ１スタート！
        if (quiznum == 2)
        {
            quiznow = quiznum2;                                         //クイズ番号はquiznum2      
        }
        if (quiznum == 3)
        {
            quiznow = quiznum3;                                         //クイズ番号はquiznum3     
        }
        //quiz＝aで今a問目。quiznum(a)のクイズ表示。opで無駄な繰り返しを防ぐ。 questionで問題表示をコントロール。(quizbook)
    }
}
