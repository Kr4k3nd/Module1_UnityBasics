using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeArjona : MonoBehaviour
{
    public CanvasUpdateArjona uiUpdate;
    public Image photo;
    public Sprite marioBross;
    public RawImage raw;
    public int number;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            uiUpdate.ScoreUpdate();
            
        }
    }
}
