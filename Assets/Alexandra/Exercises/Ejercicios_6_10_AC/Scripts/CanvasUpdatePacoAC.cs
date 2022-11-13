using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasUpdatePacoAC : MonoBehaviour
{
    public Text Score;
    public int scorepoint;

    public void ScoreUpdate()
    {
        scorepoint = scorepoint + 1;            //+1 point
        Score.text = scorepoint.ToString();     //new score
    }
}



