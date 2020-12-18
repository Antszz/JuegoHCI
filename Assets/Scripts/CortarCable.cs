using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CortarCable : MonoBehaviour
{
    public GameObject vidas;
    public GameObject control;
    public GameObject timer;
    private void OnMouseDown()
    {
        if (gameObject.name != "Cable1")
        {
            vidas.GetComponent<Vidas>().BajarVida();
        }
        else
        {
            Debug.Log(control.GetComponent<Escena>().getGameActive());
            control.GetComponent<Escena>().setGameCompleted(control.GetComponent<Escena>().getGameActive());

            SceneManager.LoadScene(14);
        }
        DestroyObject(gameObject);
    }
}
