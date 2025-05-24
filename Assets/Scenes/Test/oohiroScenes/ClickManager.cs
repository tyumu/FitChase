using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{

    //カウント用の変数を用意
    public int count = 0;

    //テキスト型の変数を用意。スコア表示
    public Text countText;

    //float型の変数を用意
    public float time = 20.0f;

    //テキスト型の変数を用意。タイム表示
    public Text timeText;

    //変数を増やす関数を作成
    public void PushButton()
    {
        //timeが0より上の時
        if (time > 0)
        {
            //countを1ずつ増やす
            count++;

            //増えた数字をテキストで表示
            countText.text = "スコア:" + count;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //timeが0以下の時
        if (time <= 0)
        {
            //テキストにカウントダウンの表示をする
            timeText.text = "タイム:0.00";
        }
        else
        {
            //カウントダウンさせる
            time -= Time.deltaTime;

            //テキストにカウントダウンの表示をする
            timeText.text = "タイム:" + time.ToString("f2");
        }
    }
}