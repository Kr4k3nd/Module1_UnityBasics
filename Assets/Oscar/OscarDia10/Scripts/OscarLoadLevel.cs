using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OscarLoadLevel : MonoBehaviour
{
    public string Level1;

    public void ChangeLv()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitLv()
    {
        Application.Quit();
    }
}
