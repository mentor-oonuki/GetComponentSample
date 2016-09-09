using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour {

    private int Score;              // 現在のスコア
    private Text ScoreText;         // スコアを表示するためのTextコンポーネント
    private Slider GaugeObject;     // ゲージを表示するためのオブジェクト

    void Start()
    {
        // スコアを0で初期化する
        Score = 0;
        // スコアを表示するためのTextコンポーネントを取得する
        ScoreText = gameObject.GetComponent<Text>();
        // ゲージを表示するためのオブジェクトを取得する
        GaugeObject = GameObject.FindObjectOfType<Slider>();
    }

    void Update()
    {
        // スコアを1加算する
        Score++;
        // スコアが1000を超えたら0に戻す
        if(Score > 1000)
        {
            Score = 0;
        }
        // スコアをTextコンポーネントに設定する(画面に表示する)
        ScoreText.text = Score.ToString();

        // 【重要】GaugeControllerスクリプトSetValue()関数を呼び出す
        GaugeObject.GetComponent<GaugeController>().SetValue(Score);
    }

}
