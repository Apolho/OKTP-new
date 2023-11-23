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

    public GameObject sceneChangeNumber;
    public string missionStatement;
    

    public void missionSelect()
    {
        //replace mission title text box with mission title text from button
        missionTitleTextBox.text = missionTitle.text;
        //replace mission statement text box with actual statement
        missionStatementTextBox.text = missionStatement;
        sceneChangeNumber.GetComponent<LoadScene>().sceneName = missionTitle.text;

    }
}
