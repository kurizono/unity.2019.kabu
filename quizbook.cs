using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizbook : MonoBehaviour {

    opning opningcs;                                       //opningから参照    
    setting settingcs;                                      //settingから参照

    public int answer = 0;                                  //答え
    public Text QuizText1,QuizText2,QuizText3;               //クイズ問題


    // Use this for initialization
    void Start () {
        opningcs = GetComponent<opning>();
        settingcs = GetComponent<setting>();
        QuizText1.text = "";
        QuizText2.text = "";
        QuizText3.text = "";
	}

    // Update is called once per frame
    void Update() {
            switch (settingcs.quiznow)                                            //クイズ番号までジャンプ
            {
                case 1:     //一問
                    QuizText1.text = "まるで耐久性のよう";
                    QuizText2.text = "まるで光のよう";                 //これが答え
                    QuizText3.text = "まるで仮面ライダーのよう";
                    answer = 2;
                    break;
                case 2:     //二問
                    QuizText1.text = "無意識の絶対音感";              //これが答え
                    QuizText2.text = "無意識の歴史";
                    QuizText3.text = "無意識のチャイルドシート";
                    answer = 1;
                    break;
                case 3:     //三問
                    QuizText1.text = "暴力は私だ";
                    QuizText2.text = "オニオンスープはわたしだ";        //これが答え
                    QuizText3.text = "耳鳴りは私だ";
                    answer = 2;
                    break;
                case 4:     //四問
                    QuizText1.text = "私を発見した";
                    QuizText2.text = "ポ〇ケモ〇ンを発見した";
                    QuizText3.text = "新種を発見した";             //これが答え
                    answer = 0;
                    break;
                case 5:     //五問
                    QuizText1.text = "身近に潜むトンネルの扉";
                    QuizText2.text = "身近に潜む好き嫌い";
                    QuizText3.text = "身近に潜む水属性";           //これが答え
                    answer = 0;
                    break;
                case 6:
                    QuizText1.text = "冗談も歩けばイベントに当たる";
                    QuizText2.text = "河童の川流れ";                  //これが答え
                    QuizText3.text = "工房も筆の誤り";
                    answer = 2;
                    break;
                case 7:
                    QuizText1.text = "相対的にボタンである";
                    QuizText2.text = "相対的に湯豆腐である";                  
                    QuizText3.text = "相対的に花丸である";           //これが答え
                    answer = 0;
                    break;
                case 8:
                    QuizText1.text = "超音波は滅べ";                  //これが答え
                    QuizText2.text = "先週は滅べ";
                    QuizText3.text = "芭蕉色は滅べ";
                    answer = 1;
                    break;
                case 9:
                    QuizText1.text = "教習車さんこんにちわ";
                    QuizText2.text = "親会社さんこんにちわ";
                    QuizText3.text = "不審者さんこんにちわ";          //これが答え
                    answer = 0;
                    break;
                case 10:
                    QuizText1.text = "火事万斉";                        //これが答え
                    QuizText2.text = "カジュアル万斉";
                    QuizText3.text = "カジノ万斉";
                    answer = 1;
                    break;
                case 11:
                    QuizText1.text = "そうだ、草を刈ろう";                        //これが答え
                    QuizText2.text = "そうだ、眼鏡を割ろう";
                    QuizText3.text = "そうだ、常識を超えよう";
                    answer = 1;
                    break;
                case 12:
                    QuizText1.text = "神様かもしれない";                        //これが答え
                    QuizText2.text = "カメラかもしれない";
                    QuizText3.text = "トランプかもしれない";
                    answer = 1;
                    break;
        }
    }
}
//answerで答えがどれか指定。questionで延々表示し続けないように設定。quiznumはsettingで設定済み。