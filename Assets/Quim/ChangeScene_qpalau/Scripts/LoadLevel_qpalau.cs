using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel_qpalau : MonoBehaviour
{

    public string level1;

    public void ChangeLevel()
    {
        SceneManager.LoadScene(level1); //ref al nivel vinculao
    }

    public void ExitGame()

    {

        Application.Quit();

    }


}