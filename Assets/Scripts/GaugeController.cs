using UnityEngine;
using UnityEngine.UI;


public class GaugeController : MonoBehaviour {

    private Slider slider;  // ゲージを表現するためのSliderオブジェクト

    void Start()
    {
        // ゲージを表現するためのSliderオブジェクト
        slider = gameObject.GetComponent<Slider>();
    }

    // 【重要】ScoreCounterからGetComponentで呼び出される関数
    public void SetValue(int score)
    {
        // ゲージの長さをScoreにて設定
        slider.value = score;
    }
}
