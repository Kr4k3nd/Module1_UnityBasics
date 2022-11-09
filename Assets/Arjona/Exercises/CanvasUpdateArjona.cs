using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasUpdateArjona : MonoBehaviour
{

    public Text score;
    public int scorepoints;
    public int previousScorepoints;


    public void ScoreUpdate()
    {
        score.text = scorepoints.ToString();
    }
}
