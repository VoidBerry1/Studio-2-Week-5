using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pbutton : MonoBehaviour
{
    [SerializeField] private int buttonIndex;

    public void OnButtonClick()
    {
        ButtonSequence buttonSequence = FindObjectOfType<ButtonSequence>();
        buttonSequence.OnButtonClick(buttonIndex);
    }
}
