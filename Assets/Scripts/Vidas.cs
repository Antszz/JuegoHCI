using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public GameObject candados;
    public static int vidas;
    public Sprite noVida;
    private static bool flag;
    // Start is called before the first frame update
    void Start()
    {
        if(candados){
            flag = false;
        }
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
                vida.GetComponent<SpriteRenderer>().sprite = noVida;
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
        vida.GetComponent<SpriteRenderer>().sprite = noVida;
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
