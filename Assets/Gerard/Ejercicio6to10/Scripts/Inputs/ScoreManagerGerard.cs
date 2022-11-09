using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManagerGerard : MonoBehaviour
{

   private Text score;
    public int MaxScore = 2;

    private void Start()
    {
        score = GetComponent<Text>();
    }

 
    public void ScoreUpdate()
    {
        score.text = (GameManager.score + MaxScore).ToString();
    }
}
