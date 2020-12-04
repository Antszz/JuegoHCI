﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public static int vidas;
    private static bool flag;
    // Start is called before the first frame update
    void Start()
    {
        if (!flag)
        {
            flag = true;
            vidas = 3;
        }
        else
        {
            GameObject vida;
            for (int i = 3; i > vidas; i--)
            {
                vida = GameObject.Find("vida" + i.ToString());
                DestroyObject(vida);
            }
        }
    }

    void EliminarCorazon()
    {
        GameObject vida;
        for (int i = 1; i <= vidas; i++)
        {
            vida = GameObject.Find("vida" + i.ToString());
            DestroyObject(vida);
        }
    }

    public void BajarVida()
    {
        GameObject vida = GameObject.Find("vida" + vidas.ToString());
        DestroyObject(vida);
        vidas--;
        if (vidas == 0)
        {
            SceneManager.LoadScene(8);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}