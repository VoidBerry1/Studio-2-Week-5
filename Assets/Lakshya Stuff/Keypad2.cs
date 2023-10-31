using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad2 : MonoBehaviour
{

    public TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;

    public GameObject dooor;
    private bool isAtDoor = false;

    void Update()
    {
        CodeText.text = codeTextValue;

        if(codeTextValue == safeCode)
        {
           Destroy(dooor);
            CodePanel.SetActive(false);
        }

        if (codeTextValue.Length >= 5)
        {
            codeTextValue = "";
        }

        if (Input.GetKey(KeyCode.E) && isAtDoor == true)
        {
            CodePanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isAtDoor = true;
        }
    }


     private void OnTriggerExit(Collider other)
     {
        isAtDoor = false;
        CodePanel.SetActive(false);
     }

     public void AddDigit(string digit)
     {
        codeTextValue += digit;
     }
}
