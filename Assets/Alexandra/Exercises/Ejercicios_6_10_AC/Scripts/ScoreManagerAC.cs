using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //we need to use the canvastext

public class ScoreManagerAC : MonoBehaviour
{
    private int currentScore;           //score ongoing
    public Text scoreText;              //mention cause the library
    public CanvasUpdatePacoAC cv;           //clic on unity variable

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;               //starting points
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")      //text
        {
            GameManager.score = GameManager.score + 1;  //bullet impact +1 point
            Debug.Log(GameManager.score);               //load new score
            cv.ScoreUpdate();                           //write new score on canvas (cv)?
        }
    }

    
}
