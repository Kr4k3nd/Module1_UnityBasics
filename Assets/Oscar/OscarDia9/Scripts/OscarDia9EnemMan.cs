using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarDia9EnemMan : MonoBehaviour
{
    public GameObject EnemProp, BossProp;
    public List<GameObject> PresentEnems;
    public int EnemsRemaining;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PresentEnems.Count < 3 && EnemsRemaining > 0)
        {
            GameObject NewEnem = Instantiate(EnemProp, transform.position, Quaternion.identity);
            PresentEnems.Add(NewEnem);
            EnemsRemaining -= 1;
        }
        else if(PresentEnems.Count == 0 && EnemsRemaining <= 0)
        {
            Instantiate(BossProp, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }

        for (int i = 0; i < PresentEnems.Count; i++)
        {
            if (PresentEnems[i] == null) { PresentEnems.Remove(PresentEnems[i]); }
        }

        if (Input.GetKeyDown(KeyCode.T)) { print(PresentEnems.Count); }
    }
}
