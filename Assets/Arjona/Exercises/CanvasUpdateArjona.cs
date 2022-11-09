using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasUpdateArjona : MonoBehaviour
{

    public Text score;
    public int scorepoints;
    

  public void ScoreUpdate()
    {
        scorepoints = scorepoints + 1;
        score.text = scorepoints.ToString();
    }
}
