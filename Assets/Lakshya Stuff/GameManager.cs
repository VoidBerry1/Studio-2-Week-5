using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List <pbutton> buttonsInOrder;
    private int currentIndex;

    void Start()
    {
        currentIndex = 0;
    }

    public void OnButtonClicked(pbutton button)
    {
        if (currentIndex < buttonsInOrder.Count && button == buttonsInOrder[currentIndex])
        {
            
            currentIndex++;
            print("++");

            if (currentIndex == buttonsInOrder.Count)
            {
                Debug.Log("YOU DID IT!!!!");
            }
        }
        else
        {
           Debug.Log("NOOOOOOO");

            currentIndex = 0; 
        }
    }
}
