using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OscarTargetControl : MonoBehaviour
{
    public Vector3 InactPos, LastPos, CurPos;
    public List<Vector3> TarPos;
    public float Timer, Goal;
    public int Score, Bonus;
    public Text ScrLabel, BonusLabel;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        Score = 0;
        Bonus = 10;
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
                Bonus = 10;
                ScrLabel.text = Score.ToString();
                BonusLabel.text = "Bonus X" + ((float)Bonus / 10).ToString();
            }
            Timer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.position = InactPos;
        Score += (100 * Bonus / 10);
        Bonus += 1;

        ScrLabel.text = Score.ToString();
        BonusLabel.text = "Bonus X" + ((float)Bonus / 10).ToString();
    }
}
