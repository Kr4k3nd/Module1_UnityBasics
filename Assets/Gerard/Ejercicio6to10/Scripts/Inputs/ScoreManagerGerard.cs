using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerGerard : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            GameManager.score = GameManager.score + 1;
            Debug.Log(GameManager.score);
        }
    }
}
