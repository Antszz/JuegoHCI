using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaparecerAyuda : MonoBehaviour
{
    private static DateTime timeNow;
    private static DateTime timeEnd;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        timeNow = DateTime.Now;
        timeEnd = timeNow.AddSeconds(10);
    }

    // Update is called once per frame
    void Update()
    {
        timeNow = DateTime.Now;
        if(timeNow > timeEnd && !flag)
        {
            flag = true;
            GameObject ayuda;
            ayuda = GameObject.Find("Ayuda1");
            if (ayuda) {
                ayuda.SetActive(false); 
            }
            ayuda = GameObject.Find("Ayuda2");
            if (ayuda)
            {
                ayuda.SetActive(false);
            }
            ayuda = GameObject.Find("Ayuda3");
            if (ayuda)
            {
                ayuda.SetActive(false);
            }
            ayuda = GameObject.Find("Ayuda4");
            if (ayuda)
            {
                ayuda.SetActive(false);
            }
        }
    }
}
