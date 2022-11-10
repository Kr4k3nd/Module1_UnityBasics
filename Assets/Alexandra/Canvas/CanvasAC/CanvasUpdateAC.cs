using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //tenemos acceso a un tipo de variable que es text.
                            //Es una librería. Y nos dará error Text public si no lo ponemos

public class CanvasUpdateAC : MonoBehaviour
{
    public Text score;
    public int scorepoints;     //hará que convertirá un número entero a scorepoints para cadenas de texto. Pasarlo de string a text y de text a string.
                                //string y text es como lo de decimal y entero y poderlos imprimirlos en pantalla
                                //ahora iremos al script del cubo
    public void ScoreUpdate()      //actualizar la puntuación. Coid es nulo que está vacía.
    {

        scorepoints = scorepoints +1;
        score.text = scorepoints.ToString();

    }
}
