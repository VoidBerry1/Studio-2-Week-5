using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pbutton : MonoBehaviour
{
    public int buttonOrder;
    public Color highlightColor;
    private Image buttonImage;
    private bool isClicked;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        isClicked = false;
    }

    public void OnButtonClick()
    {
        if (!isClicked)
        {
            buttonImage.color = highlightColor;
            isClicked = true;

            // Use the existing GameManager reference instead of trying to find the object
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.OnButtonClicked(this);
        }
    }

    public void ResetButton()
    {
        buttonImage.color = Color.white;
        isClicked = false;
    }
}