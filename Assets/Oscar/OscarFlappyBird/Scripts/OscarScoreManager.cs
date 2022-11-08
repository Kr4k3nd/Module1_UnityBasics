using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarScoreManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            OscarGameManager.Score = OscarGameManager.Score + 1;
            Debug.Log(OscarGameManager.Score);
        }
    }
}
