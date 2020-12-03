using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int timer;
    public Text timerText;
    private DateTime timeNow;
    private DateTime timeEnd;
    private TimeSpan diffTime;
    // Start is called before the first frame update
    void Start()
    {
        timeNow = DateTime.Now;
        timeEnd = timeNow.AddMinutes(15);
        Debug.Log(timeEnd);
    }

    // Update is called once per frame
    void Update()
    {
        diffTime = timeEnd - timeNow;
        String cronometro = diffTime.ToString(@"mm\:ss");
        Debug.Log(cronometro);
        timeNow = DateTime.Now;
        timerText.text = cronometro;
        //Debug.Log(auxTimer);
        //Debug.Log(auxTimer.Minutes);
    }
}
