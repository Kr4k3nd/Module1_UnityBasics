using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIUpdateScore : MonoBehaviour
{

    public Text scoreText;

    private void Update()
    {
        scoreText.text = GameManager.score.ToString();
    }
}

