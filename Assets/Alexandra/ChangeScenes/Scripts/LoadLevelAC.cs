using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//cargar escenas. Cuidado si no se carga la librería estará gris claro que no haya un archivo que tenga el mismo nombre

public class LoadLevelAC : MonoBehaviour
{

    public string level1;   //cadena de texto "___"

    public void ChangeLevel()
    {
        SceneManager.LoadScene(level1); //referencia al level 1 del string
    }

    public void ExitGame()
    {
        Application.Quit();

    }



}
