using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDestructor : MonoBehaviour
{
    public ScoreManagerGerard scoreManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            scoreManager.ScoreUpdate();
            // GameManager.score = GameManager.score + 1;

        }
    }
}