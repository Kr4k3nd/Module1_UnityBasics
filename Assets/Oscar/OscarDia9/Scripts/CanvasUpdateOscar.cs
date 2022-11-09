using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUpdateOscar : MonoBehaviour
{
    public int Score;
    public Text ScoreLabel;

    public void ScoreUpdate()
    {
        Score += 1;
        ScoreLabel.text = Score.ToString();
    }
}
