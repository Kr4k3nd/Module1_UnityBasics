using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OscarTargetControl : MonoBehaviour
{
    public Vector3 InactPos, LastPos, CurPos;
    public List<Vector3> TarPos;
    public float Timer, Goal;
    public int Score;
    public Text ScrLabel;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Ejercicio 7: Target se mueve a distintas posiciones
        Timer += Time.deltaTime;

        if(Timer >= Goal)
        {
            if(transform.position == InactPos)
            {
                transform.position = TarPos[Random.Range(0, TarPos.Count)];
            }
            else
            {
                transform.position = InactPos;
            }
            Timer = 0;
        }

        ScrLabel.text = Score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.position = InactPos;
        Score += 1;
    }
}
