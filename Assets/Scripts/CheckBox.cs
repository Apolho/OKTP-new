using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckBox : MonoBehaviour
{
    public Image[] checkBox;
    public TextMeshProUGUI feedBack;
    private bool allGreen;
    private bool allWhite;
    public GameObject feedBackButton;
    public void Continue()
    {
        allGreen = true;
        allWhite = true;
        
        for (int i = 0; i < checkBox.Length; i++)
        {
            if (checkBox[i].GetComponent<Image>().color == Color.white && checkBox[i].CompareTag("isMandate"))
            {
                //feedBack.SetActive(true);
                Debug.Log("Wrong");
                allGreen = false;
            }
            if (checkBox[i].GetComponent<Image>().color == Color.green && checkBox[i].CompareTag("isNotMandate"))
            {
                Debug.Log("green");
                allWhite = false;
            }
            
        }

        if (allGreen == false && allWhite == false)
        {
            //make message say they chose incorrect ones and missed correct ones
            feedBack.text =
                "Hmm... I don't think we are allowed to do all of these. \n On top of that, you may have missed a few of our actual responsibilities." +
                "\n Double check your answers and see what's wrong!";
            feedBackButton.SetActive(true);
        }
        else if(allGreen == false && allWhite == true)
        {
            //message says they missed correct ones
            feedBack.text = "Hmm... I think you may have missed a few mandates." +
            "\n Double check your answers and see what's wrong!";
            feedBackButton.SetActive(true);

        }
        else if (allGreen == true && allWhite == false)
        {
            //message says they chose incorrect ones
            feedBack.text = "Hmm... I don't think you are allowed to do all of these." +
                            "\n Double check your answers and see what's wrong!";
            feedBackButton.SetActive(true);

        }
        else if (allGreen == true && allWhite == true)
        {
            SceneManager.LoadScene("Learn More");
        }

    }
    public void ChangeColor()
    {
        if (gameObject.GetComponent<Image>().color == Color.white)
        {
            gameObject.GetComponent<Image>().color = Color.green;
        }
        else if (gameObject.GetComponent<Image>().color == Color.green)
        {
            gameObject.GetComponent<Image>().color = Color.white;
        }
    }
}
