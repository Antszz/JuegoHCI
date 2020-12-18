using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVista : MonoBehaviour
{
    public GameObject control;
    public GameObject btn;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i<5; i++)
        {
            if (!control.GetComponent<Escena>().getGameCompleted(i))
            {
                return;
            }
        }
        btn.SetActive(true);
        
    }

}
