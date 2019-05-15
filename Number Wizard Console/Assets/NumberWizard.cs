using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Un po' di OOP :)
    private int max;
    private int min;
    private int guess;

    public NumberWizard()
    {
        max = 1000;
        min = 1;
        guess = 500;
    }

    /*
     * Start is called before the first frame update
     * Funzione di inizializzazione
    */
    void Start()
    {
        Debug.Log("Welcome to Number Wizard!!!");
        Debug.Log("Pick a number and don't tell me what is it...");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is 1: " + min);
        Debug.Log("Push UP = higher, Push DOWN = Lower, Push ENTER = Correct");
        Debug.Log("Your number is " + guess + "?");
    }

    /*
     * Update is called once per frame
     * Dipende da quante frame il calcolatore riesce a generare
     * Se tengo il tasto premuto per 100fps -> stampa 100 volte il messaggio
    */
    void Update()
    {
        /*
         * Usando if in successione posso premere piu' tasti contemporaneamente
         * Con else if limito ad uno solo tasto
         * 
         * Dipende dai casi (multiple press - single press)
        */

        if(Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("UpArrow is pressed");
            guess = (min + guess) / 2;
            Debug.Log("Your number is " + guess + "?");
        }
        else if(Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("DownArrow is pressed");
            guess = (max + guess) / 2;
            Debug.Log("Your number is " + guess + "?");
        }
        else if(Input.GetKey(KeyCode.Return)) {
            Debug.Log("Return is pressed");
            Debug.Log("Aahah i got it ;-\\)");
            Debug.Log("Your number is " + guess + "?");
        }
    }
}
