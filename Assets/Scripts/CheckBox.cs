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
    public int amountOfMandates;
    public GameObject feedBack;

    public void Continue()
    {
        for (int i = 0; i < checkBox.Length; i++)
        {
            if (checkBox[i].GetComponent<Image>().color == Color.white)
            {
                feedBack.SetActive(true);
                Debug.Log("Wrong");
                return;
            }
            else if (checkBox[amountOfMandates].GetComponent<Image>().color == Color.green)
            {
                //SceneManager.LoadScene("Learn More");
                Debug.Log("Right");
            }
            else
            {
                return;
            }
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
