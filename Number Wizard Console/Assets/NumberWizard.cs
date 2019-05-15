using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    /*
     * Start is called before the first frame update
     * Funzione di inizializzazione
    */
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
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
            min = guess;
            NextGuess();
        }
        else if(Input.GetKey(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        else if(Input.GetKey(KeyCode.Return)) {
            Debug.Log("Return is pressed");
            Debug.Log("Aahah i got it ;-\\)");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Your number is " + guess + "?");
    }


}
