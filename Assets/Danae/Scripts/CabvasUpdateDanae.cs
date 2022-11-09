using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CabvasUpdateDanae : MonoBehaviour
{
    public Text score;
    public int scorepoints;

    // Start is called before the first frame update
    public void ScoreUpdate()
    {
        scorepoints = scorepoints + 1;
        score.text = scorepoints.ToString(); //cambia a puntos a string a texto
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
