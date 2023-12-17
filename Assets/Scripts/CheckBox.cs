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

    public Sprite selected;
    public Sprite unselected;

    public Sprite counter1;
    public Sprite counter2;
    public Sprite counter3;

    public Image counterImage;

    public static int counter;
    public void Continue()
    {
        allGreen = true;
        allWhite = true;
        
        for (int i = 0; i < checkBox.Length; i++)
        {
            if (checkBox[i].GetComponent<Image>().sprite == unselected && checkBox[i].CompareTag("isMandate"))
            {
                //feedBack.SetActive(true);
                Debug.Log("Wrong");
                allGreen = false;
            }
            if (checkBox[i].GetComponent<Image>().sprite == selected && checkBox[i].CompareTag("isNotMandate"))
            {
                Debug.Log("green");
                allWhite = false;
            }
            
        }

        if (allGreen == false && allWhite == false && counter < 2)
        {
            //make message say they chose incorrect ones and missed correct ones
            feedBack.text =
                "Hmm... I don't think we are allowed to do all of these. \n On top of that, you may have missed a few of our actual responsibilities." +
                "\n Double check your answers and see what's wrong!";
            feedBackButton.SetActive(true);
        }
        else if(allGreen == false && allWhite == true && counter < 2)
        {
            //message says they missed correct ones
            feedBack.text = "Hmm... You have missed a few mandates." +
            "\n Double check your answers and see what's wrong!";
            feedBackButton.SetActive(true);

        }
        else if (allGreen == true && allWhite == false && counter < 2)
        {
            //message says they chose incorrect ones
            feedBack.text = "Hmm... You are not allowed to do all of these." +
                            "\n Double check your answers and see what's wrong!";
            feedBackButton.SetActive(true);

        }
        else if (allGreen == false && allWhite == false && counter == 2)
        {
            feedBack.text =
                "Hmm... We are not allowed to do all of these. \n On top of that, you have missed a few of our actual responsibilities." +
                "\n Sadly, you ran out of guesses. Nonetheless, you did a great job!";
            feedBackButton.SetActive(true);
        }
        else if (allGreen == false && allWhite == true && counter == 2)
        {
            feedBack.text = "Hmm... You may have missed a few mandates." +
                            "\n Sadly, you ran out of guesses. Nonetheless, you did a great job!";
            feedBackButton.SetActive(true);
        }
        else if (allGreen == true && allWhite == false && counter == 2)
        {
            feedBack.text = "Hmm... We are not allowed to do all of these." +
                            "\n Sadly, you ran out of guesses. Nonetheless, you did a great job!";
            feedBackButton.SetActive(true);

        }
        else if (allGreen == true && allWhite == true)
        {
            SceneManager.LoadScene("Learn More");
        }

    }
    public void ChangeColor()
    {
        if (gameObject.GetComponent<Image>().sprite == unselected)
        {
            gameObject.GetComponent<Image>().sprite = selected;
        }
        else if (gameObject.GetComponent<Image>().sprite == selected)
        {
            gameObject.GetComponent<Image>().sprite = unselected;
        }
    }

    //when clicked, this function will make the counter go up. When it is passed 2 it will change scene.
    public void FeedbackButton()
    {
        if (counterImage.sprite == counter3)
        {
            counter++;
            counterImage.sprite = counter2;
        }
        else if (counterImage.sprite == counter2)
        {
            counter++;
            counterImage.sprite = counter1;
        }
        else if (counterImage.sprite == counter1)
        {
            SceneManager.LoadScene("Learn More");
        }
    }
}
