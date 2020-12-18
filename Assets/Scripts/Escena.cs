using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    public Text textPzs;

    public Text cantPzsTxt1;
    public Text cantPzsTxt2;
    public Text cantPzsTxt3;
    public Text cantPzsTxt4;
    public Text codigoIntercambio;

    public GameObject btnCanjear1;
    public GameObject btnCanjear2;
    public GameObject btnCanjear3;
    public GameObject btnCanjear4;

    public Text inputName;
    public static string name;
    public static bool game1Completed;
    public static bool game2Completed;
    public static bool game3Completed;
    public static bool game4Completed;

    public static int gameActive;

    public static int piezaCambiante;

    public static bool pieza1Completed;
    public static bool pieza2Completed;
    public static bool pieza3Completed;
    public static bool pieza4Completed;

    public static int cantPieza1;
    public static int cantPieza2;
    public static int cantPieza3;
    public static int cantPieza4;

    public static int totalPiezas;

    public GameObject error;
    public GameObject errorCodigo;
    public GameObject ctrlCandados;
    public Sprite candadoSpr;
    public Sprite candadoSprB;

    public Sprite spritePz1;
    public Sprite spritePz2;
    public Sprite spritePz3;
    public Sprite spritePz4;
    public GameObject pzsCambiante;

    public Text inputCodigo;


    public void setPiezaCambiante(int id)
    {
        piezaCambiante = id;
    }

    public void setGameActive(int id)
    {
        gameActive = id;
    }
    public int getGameActive()
    {
        return gameActive;
    }

    public void canjearPremio()
    {
        cantPieza1--;
        cantPieza2--;
        cantPieza3--;
        cantPieza4--;
        totalPiezas -= 4;
    }

    public void setPiezaCompleted()
    {
        Debug.Log(inputName.text);
        if (inputName.text == "aa1")
        {
            pieza1Completed = true;
            cantPieza1++;
        }
        else if (inputName.text == "aa2")
        {
            pieza2Completed = true;
            cantPieza2++;
        }
        else if (inputName.text == "aa3")
        {
            pieza3Completed = true;
            cantPieza3++;
        }
        else if (inputName.text == "aa4")
        {
            pieza4Completed = true;
            cantPieza4++;
        }
        else
        {
            error.SetActive(true);
            return;
        }
        error.SetActive(false);
        SceneManager.LoadScene(12);
    }

    public void IntercambiarPzs(){
        if(inputCodigo.text == codigoIntercambio.text || (inputCodigo.text != "COD1" && inputCodigo.text != "COD2" && inputCodigo.text != "COD3" && inputCodigo.text != "COD4")){
            errorCodigo.SetActive(true);
        }
        else{
            errorCodigo.SetActive(false);
            if(piezaCambiante == 1){
                cantPieza1--;
            }
            if(piezaCambiante == 2){
                cantPieza2--;
            }
            if(piezaCambiante == 3){
                cantPieza3--;
            }
            if(piezaCambiante == 4){
                cantPieza4--;
            }

            if(inputCodigo.text == "COD1")
                cantPieza1++;
            if(inputCodigo.text == "COD2")
                cantPieza2++;
            if(inputCodigo.text == "COD3")
                cantPieza3++;
            if(inputCodigo.text == "COD4")
                cantPieza4++;
            SceneManager.LoadScene(16);
        }
    }

    private void Start()
    {

        if(pzsCambiante){
            if(piezaCambiante == 1){
                pzsCambiante.GetComponent<SpriteRenderer>().sprite = spritePz1;
                codigoIntercambio.text = "COD1";
            }
            if(piezaCambiante == 2){
                pzsCambiante.GetComponent<SpriteRenderer>().sprite = spritePz2;
                codigoIntercambio.text = "COD2";
            }
            if(piezaCambiante == 3){
                pzsCambiante.GetComponent<SpriteRenderer>().sprite = spritePz3;
                codigoIntercambio.text = "COD3";
            }
            if(piezaCambiante == 4){
                pzsCambiante.GetComponent<SpriteRenderer>().sprite = spritePz4;
                codigoIntercambio.text = "COD4";
            }
        }

        if(cantPzsTxt1){
            cantPzsTxt1.text = "X " + cantPieza1.ToString();
            cantPzsTxt2.text = "X " + cantPieza2.ToString();
            cantPzsTxt3.text = "X " + cantPieza3.ToString();
            cantPzsTxt4.text = "X " + cantPieza4.ToString();
            if(cantPieza1 == 0){
                btnCanjear1.SetActive(false);
            }
            else
                btnCanjear1.SetActive(true);

            if(cantPieza2 == 0){
                btnCanjear2.SetActive(false);
            }
            else
                btnCanjear2.SetActive(true);

            if(cantPieza3 == 0){
                btnCanjear3.SetActive(false);
            }
            else
                btnCanjear3.SetActive(true);

            if(cantPieza4 == 0){
                btnCanjear4.SetActive(false);
            }
            else
                btnCanjear4.SetActive(true);
        }

        totalPiezas = cantPieza1 + cantPieza2 + cantPieza3 + cantPieza4;
        if (textPzs)
        {
            textPzs.text = totalPiezas.ToString();
        }

        if(cantPieza1 <= 0)
        {
            pieza1Completed = false;
            game1Completed = false;
        }
        else{
            pieza1Completed = true;
        }
        if (cantPieza2 <= 0)
        {
            pieza2Completed = false;
            game2Completed = false;
        }
        else{
            pieza2Completed = true;
        }
        if (cantPieza3 <= 0)
        {
            pieza3Completed = false;
            game3Completed = false;
        }
        else{
            pieza3Completed = true;
        }
        if (cantPieza4 <= 0)
        {
            pieza4Completed = false;
            game4Completed = false;
        }
        else{
            pieza4Completed = true;
        }

        if (pieza1Completed)
        {
            GameObject pieza = GameObject.Find("descuento1");
            pieza.GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Find("candado1").GetComponent<SpriteRenderer>().sprite = candadoSpr;
        }
        else
        {
            GameObject pieza = GameObject.Find("descuento1");
            pieza.GetComponent<SpriteRenderer>().color = Color.gray;
            GameObject candado = GameObject.Find("candado1");
            candado.GetComponent<SpriteRenderer>().sprite = candadoSprB;
            GameObject.Find("Ayuda1").SetActive(false);
        }
        if (pieza2Completed)
        {
            GameObject pieza = GameObject.Find("descuento2");
            pieza.GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Find("candado2").GetComponent<SpriteRenderer>().sprite = candadoSpr;
        }
        else
        {
            GameObject pieza = GameObject.Find("descuento2");
            pieza.GetComponent<SpriteRenderer>().color = Color.gray;
            GameObject.Find("Ayuda2").SetActive(false);
            GameObject candado = GameObject.Find("candado2");
            candado.GetComponent<SpriteRenderer>().sprite = candadoSprB;
        }
        if (pieza4Completed)
        {
            GameObject pieza = GameObject.Find("descuento4");
            pieza.GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Find("candado4").GetComponent<SpriteRenderer>().sprite = candadoSpr;
        }
        else
        {
            GameObject pieza = GameObject.Find("descuento4");
            pieza.GetComponent<SpriteRenderer>().color = Color.gray;
            GameObject.Find("Ayuda4").SetActive(false);
            GameObject candado = GameObject.Find("candado4");
            candado.GetComponent<SpriteRenderer>().sprite = candadoSprB;
        }
        if (pieza3Completed)
        {
            GameObject pieza = GameObject.Find("descuento3");
            pieza.GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Find("candado3").GetComponent<SpriteRenderer>().sprite = candadoSpr;
        }
        else
        {
            GameObject pieza = GameObject.Find("descuento3");
            pieza.GetComponent<SpriteRenderer>().color = Color.gray;
            GameObject.Find("Ayuda3").SetActive(false);
            GameObject candado = GameObject.Find("candado3");
            candado.GetComponent<SpriteRenderer>().sprite = candadoSprB;
        }

        if (game1Completed)
        {
            GameObject pieza = GameObject.Find("descuento1");
            pieza.GetComponent<SpriteRenderer>().color = Color.green;
            GameObject.Find("Ayuda1").SetActive(false);
            GameObject.Find("candado1").SetActive(false);
        }
        if (game2Completed)
        {
            GameObject pieza = GameObject.Find("descuento2");
            pieza.GetComponent<SpriteRenderer>().color = Color.green;
            GameObject.Find("Ayuda2").SetActive(false);
            GameObject.Find("candado2").SetActive(false);
        }
        if (game4Completed)
        {
            GameObject pieza = GameObject.Find("descuento4");
            pieza.GetComponent<SpriteRenderer>().color = Color.green;
            GameObject.Find("Ayuda4").SetActive(false);
            GameObject.Find("candado4").SetActive(false);
        }
        if (game3Completed)
        {
            GameObject pieza = GameObject.Find("descuento3");
            pieza.GetComponent<SpriteRenderer>().color = Color.green;
            GameObject.Find("Ayuda3").SetActive(false);
            GameObject.Find("candado3").SetActive(false);
        }

    }
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
    public void setGameCompleted(int i)
    {
        if(i == 1)
        {
            game1Completed = true;
        }
        else if(i == 2)
        {
            game2Completed = true;
        }
        else if (i == 3)
        {
            game3Completed = true;
        }
        else
        {
            game4Completed = true;
        }
    }
    public bool getGameCompleted(int i)
    {
        if (i == 1)
        {
            return game1Completed;
        }
        else if (i == 2)
        {
            return game2Completed;
        }
        else if (i == 3)
        {
            return game3Completed;
        }
        else
        {
            return game4Completed;
        }
    }

    public bool getpiezaCompleted(int i)
    {
        if (i == 1)
        {
            return pieza1Completed;
        }
        else if (i == 2)
        {
            return pieza2Completed;
        }
        else if (i == 3)
        {
            return pieza3Completed;
        }
        else
        {
            return pieza4Completed;
        }
    }
}
