using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    public Text inputName;
    public static string name;
    public static bool game1Completed;
    public static bool game2Completed;
    public static bool game3Completed;
    public static bool game4Completed;
    // Update is called once per frame
    private void Start()
    {
        if (game1Completed)
        {
            GameObject miniGame = GameObject.Find("MiniJuego1");
            miniGame.GetComponent<SpriteRenderer>().sprite = miniGame.GetComponent<CambiarMinijuego>().spriteGameComplete;
        }
        if (game2Completed)
        {
            GameObject miniGame = GameObject.Find("MiniJuego2");
        }
        if (game3Completed)
        {
            GameObject miniGame = GameObject.Find("MiniJuego3");
        }
        if (game4Completed)
        {
            GameObject miniGame = GameObject.Find("MiniJuego4");
        }
    }
    public void cambiarScena(int number)
    {
        SceneManager.LoadScene(number);
    }
    public void setName()
    {
        name = inputName.text;
        Debug.Log(name);
    }

    public void printName()
    {
        Debug.Log(name);
    }
    public string getName()
    {
        return name;
    }
    public void setGameCompleted(int i)
    {
        if(i == 1)
        {
            game1Completed = true;
        }
        else if(i == 2)
        {
            game2Completed = true;
        }
        else if (i == 2)
        {
            game3Completed = true;
        }
        else
        {
            game4Completed = true;
        }
    }
    public bool getGameCompleted(int i)
    {
        if (i == 1)
        {
            return game1Completed;
        }
        else if (i == 2)
        {
            return game2Completed;
        }
        else if (i == 2)
        {
            return game3Completed;
        }
        else
        {
            return game4Completed;
        }
    }
}
