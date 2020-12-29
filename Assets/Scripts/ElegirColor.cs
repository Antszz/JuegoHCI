using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirColor : MonoBehaviour
{
    public GameObject vidas;
    public GameObject control;
    private void OnMouseDown()
    {
        if (gameObject.name != "cuadrado4")
        {
            vidas.GetComponent<Vidas>().BajarVida();
        }
        else
        {
            SceneManager.LoadScene(23);
        }
    }
}
