using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlAyudante : MonoBehaviour
{
    private bool cable1Completed;
    private bool cable2Completed;
    private bool cable3Completed;
    private bool cable4Completed;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cable1Completed && cable2Completed && cable3Completed && cable4Completed)
        {
            if (!flag)
            {
                flag = true;
                SceneManager.LoadScene(10);
            }
        }
    }

    public void setCableCompleted(char a)
    {
        if(a == '1')
        {
            cable1Completed = true;
        }
        if (a == '2')
        {
            cable2Completed = true;
        }
        if (a == '3')
        {
            cable3Completed = true;
        }
        if (a == '4')
        {
            cable4Completed = true;
        }
    }
    public void cambiarScena(int number)
    {
        SceneManager.LoadScene(number);
    }
}
