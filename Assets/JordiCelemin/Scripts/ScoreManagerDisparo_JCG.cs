using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManagerDisparo_JCG : MonoBehaviour
{
    private int currentScore;
    public Text scoreText;
    public CanvasUpdateJordiCelemin cv;
    // Use this for initialization
    void Start()
    {
        currentScore = 0;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            GameManager.score = GameManager.score + 1;
            Debug.Log(GameManager.score);
            cv.ScoreUpdate();
        }
    }

}
