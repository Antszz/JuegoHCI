using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CortarCable : MonoBehaviour
{
    public GameObject vidas;
    public GameObject control;
    private void OnMouseDown()
    {
        if (gameObject.name != "Cable1")
        {
            vidas.GetComponent<Vidas>().BajarVida();
        }
        else
        {
            control.GetComponent<Escena>().setGameCompleted(1);
            SceneManager.LoadScene(3);
        }
        DestroyObject(gameObject);
    }
}
