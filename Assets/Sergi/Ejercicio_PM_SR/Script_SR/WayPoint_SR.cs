using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayPoint_SR : MonoBehaviour
{
    public Vector3 InactPos, LastPos, CurPos;   // Es un public asi que saldra en la interfaz de Unity - Logro entender que InactPos es cuando esta inactivo, LastPos es la ultima posicion y CurPos sera la current que significa la actual.
    public List<Vector3> TarPos;                // Este public obtiene un Vector3, que seguramente sea el Vector 3 de la anterior funcion y el TarPos sera del Target Position.
    public float Timer, Goal;                   // Una variable publica que nos dira el tiempo de intervalizacion entre cada target y el goal que sera para sumar puntos.
    public int Score, Bonus;                    // Score con numeros enteros ya que cada target eliminado sumara un punto al Canvas.
    public Text ScrLabel, BonusLabel;           // ScrLabel  supongo que sera el aumento de puntos dicho en el anterior punto pero haciendo enfasis en el texto de dicho Canva.


    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        Score = 0;
        Bonus = 10;

        //Cuando empezamos la partida nos saldra el tiempo en 0, putuacion en 0 y el tema del bonus no se que es pero, ahi esta...
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;                // El Timer hace referencia a la funcion publica de Timer la cual luego tiene se suma al Time.deltaTime que esta tenia que ver algo con el tema de los FPS a los que puede correr tu pc el juego...

        if(Timer >= Goal)                       //Si Timer es mayor a Goal...
        {
            if(transform.position == InactPos)  // Si Tranform.position es igual a InactPos...
            {
                transform.position = TarPos[Random.Range(0, TarPos.Count)];     // Selecciona un rango entre 0 y TarPos.Count
            }
            else
            {
                transform.position = InactPos;  // Repite la misma funcion que el if.
                Bonus = 10;                     // Bonus = 10 le estas dando un valor predeterminado.
            }
            Timer = 0;                          // Timer = 0 le estas dando un valor predeterminado.
        }

        ScrLabel.text = Score.ToString();       // Info del score que debe hacer el texto del canva al sumar puntos o destruir un target 
        BonusLabel.text = "Bonus: " + ((float)Bonus/10).ToString();             // El Bonus dara 10 mas a texto

    }

    private void OnTriggerEnter(Collider other)
    {
        transform.position = InactPos;          // 
        Score += (100 * Bonus / 10);            //
        Bonus += 1;                             //
    }
}
