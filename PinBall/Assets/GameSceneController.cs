using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneController : MonoBehaviour
{
    private Text scoreText;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //スコアテキストオブジェクトを探す
        GameObject gameScoreText = GameObject.Find("ScoreText");
        //スコアテキストの中にあるテキストを呼び出す
        scoreText = gameScoreText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //箱から受け取った数字で加算処理を行う
    public void AddScore(int num)
    {
        //スコア加算する
        score += num;
        //スコアの表示更新
        scoreText.text = score.ToString();
    }
}