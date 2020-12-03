using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    public GameObject control;
    public Text thisText;
    // Start is called before the first frame update
    void Start()
    {
        SetNameHello();
    }
    
    public void SetNameHello()
    {
        thisText.text = "Hola " + control.GetComponent<Escena>().getName();
    }

}
