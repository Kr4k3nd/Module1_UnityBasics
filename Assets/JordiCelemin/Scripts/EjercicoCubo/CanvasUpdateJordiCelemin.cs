using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUpdateJordiCelemin : MonoBehaviour
{

    public Text score;
    public int scorepoint;

   public void ScoreUpdate()
    {
        scorepoint = scorepoint + 1;
        score.text = scorepoint.ToString();
    }
}
