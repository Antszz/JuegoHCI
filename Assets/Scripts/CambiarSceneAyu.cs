using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarSceneAyu : MonoBehaviour
{
    DateTime timeNow;
    DateTime timeEnd;
    // Start is called before the first frame update
    void Start()
    {
        timeNow = DateTime.Now;
        timeEnd = timeNow.AddSeconds(5);
    }

    // Update is called once per frame
    void Update()
    {
        timeNow = DateTime.Now;
        if(timeEnd <= timeNow)
            SceneManager.LoadScene(4);
    }
}
