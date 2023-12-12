using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MissionMenu : MonoBehaviour
{
    public TextMeshProUGUI missionStatementTextBox;
    public TextMeshProUGUI missionTitleTextBox;
    public TextMeshProUGUI missionTitle;

    public GameObject yes;
    public GameObject no;
    
    public string missionStatement;
    
    public string yesTitle;
    public string noTitle;
    public string yesAnswer;
    public string noAnswer;

    public TextMeshProUGUI yesAnswerTitleBox;
    public TextMeshProUGUI noAnswerTitleBox;
    public TextMeshProUGUI yesAnswerBox;
    public TextMeshProUGUI noAnswerBox;

    public void missionSelect()
    {
        //replace mission title text box with mission title text from button
        missionTitleTextBox.text = missionTitle.text;
        //replace mission statement text box with actual statement
        missionStatementTextBox.text = missionStatement;

    }

    public void SetMission()
    {
        yes.GetComponent<MissionMenu>().yesAnswer = yesAnswer;
        yes.GetComponent<MissionMenu>().yesTitle = yesTitle;
        no.GetComponent<MissionMenu>().noAnswer = noAnswer;
        no.GetComponent<MissionMenu>().noTitle = noTitle;

    }
    public void Feedback()
    {
        //if button is the yes button, it will show whatever the yes answer is. 
        if (gameObject.CompareTag("Yes"))
        {
            yesAnswerBox.text = yesAnswer;
            yesAnswerTitleBox.text = yesTitle;
        }
        //if button is no button, it will show whatever the no answer is
        else if (gameObject.CompareTag("No"))
        {
            noAnswerBox.text = noAnswer;
            noAnswerTitleBox.text = noTitle;
        }
    }

}
