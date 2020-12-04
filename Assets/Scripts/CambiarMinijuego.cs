using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarMinijuego : MonoBehaviour
{
    public int scenaMinijuego;
    public GameObject control;
    public int id;
    public Sprite spriteGameComplete;

    public void cambiarScena()
    {
        SceneManager.LoadScene(scenaMinijuego);
    }

    private void OnMouseDown()
    {
        if( !control.GetComponent<Escena>().getGameCompleted(id))
            cambiarScena();
    }

}
