using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    public Text inputName;
    public static string name;
    // Update is called once per frame
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
}
