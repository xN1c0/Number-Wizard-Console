using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard!!!");
        Debug.Log("Pick a number...");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is 1: " + min);
        Debug.Log("Push UP = higher, Push DOWN = Lower, Push ENTER = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("UpArrow is pressed");
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("DownArrow is pressed");
        }
        if(Input.GetKey(KeyCode.Return)) {
            Debug.Log("Return is pressed");
        }
    }
}
