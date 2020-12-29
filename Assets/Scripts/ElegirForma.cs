using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirForma : MonoBehaviour
{
    public GameObject vidas;
    public GameObject control;
    private void OnMouseDown()
    {
        if (gameObject.name != "circulo")
        {
            vidas.GetComponent<Vidas>().BajarVida();
        }
        else
        {
            control.GetComponent<Escena>().setGameCompleted(control.GetComponent<Escena>().getGameActive());
            SceneManager.LoadScene(14);
        }
    }
}
