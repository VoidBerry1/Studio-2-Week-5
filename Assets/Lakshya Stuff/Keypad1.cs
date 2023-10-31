using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad1 : MonoBehaviour
{
    public GameObject canvas;
    private bool playerInRange;

    void Start()
    {
        canvas.SetActive(false);
    }

    void Update()
    {
        if (playerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                canvas.SetActive(true);

                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
        }
        else
        {
            canvas.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
