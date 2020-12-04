using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int timer;
    public Text timerText;
    private static DateTime timeNow;
    private static DateTime timeEnd;
    private TimeSpan diffTime;
    public static bool flag;
    // Start is called before the first frame update
    void Start()
    {
        if (!flag)
        {
            flag = true;
            timeNow = DateTime.Now;
            timeEnd = timeNow.AddMinutes(15);
        }
    }

    // Update is called once per frame
    void Update()
    {
        diffTime = timeEnd - timeNow;
        String cronometro = diffTime.ToString(@"mm\:ss");
        timeNow = DateTime.Now;
        timerText.text = cronometro;
        //Debug.Log(auxTimer);
        //Debug.Log(auxTimer.Minutes);
    }
}
