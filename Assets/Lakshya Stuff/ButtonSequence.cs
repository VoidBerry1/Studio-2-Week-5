using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonSequence : MonoBehaviour
{
    public Button[] buttons;
    public int[] sequence;
    public int currentSequenceIndex = 0;
     public TextMeshProUGUI messageText;
     public GameObject systemmm;
     public GameObject hint;

private void Start()
    {
        messageText.text = "";
    }

    public void OnButtonClick(int buttonIndex)
    {
        if (buttonIndex == sequence[currentSequenceIndex])
        {
            messageText.text = "Correct button!";
            currentSequenceIndex++;
        }
        else
        {
            messageText.text = "Wrong button!";
            currentSequenceIndex = 0;
        }

        if (currentSequenceIndex == sequence.Length)
        {
            messageText.text = "Sequence complete!";
            currentSequenceIndex = 0;

            Destroy(systemmm);
            hint.SetActive(true);
        }
    }
}