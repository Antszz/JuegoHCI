using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goMinijuego : MonoBehaviour
{
    public GameObject control;
    public int id;
    private void OnMouseDown()
    {
        if (control.GetComponent<Escena>().getpiezaCompleted(id) && !control.GetComponent<Escena>().getGameCompleted(id))
        {
            control.GetComponent<Escena>().setGameActive(id);
            SceneManager.LoadScene(20);
        }
    }
}
