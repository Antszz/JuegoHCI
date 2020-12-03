using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    private DateTime timeNow;
    // Start is called before the first frame update
    void Start()
    {
        timeNow = DateTime.Now;
        Debug.Log(timeNow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
