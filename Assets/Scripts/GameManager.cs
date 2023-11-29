using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI[] textBoxes;
    public TextMeshProUGUI[] branchTextBoxes;

    public TextMeshProUGUI resolutionTextBox;
    public GameObject continueButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //array goes through textboxes.
        for (int i = 0; i < textBoxes.Length; i++)
        {
            if (textBoxes[2].gameObject.CompareTag("Selected")) //when last textbox is tagged selected
            {
                continueButton.SetActive(true); //continue button comes out
            }
            
        }

        resolutionTextBox.text = textBoxes[0].text + "\n" + textBoxes[1].text + "\n" + textBoxes[2].text; //changes resolution textbox with each mandate

        //military branch text box
        branchTextBoxes[0].text = textBoxes[0].text;
        branchTextBoxes[1].text = textBoxes[1].text;
        branchTextBoxes[2].text = textBoxes[2].text;
        //police branch text box
        branchTextBoxes[3].text = textBoxes[0].text;
        branchTextBoxes[4].text = textBoxes[1].text;
        branchTextBoxes[5].text = textBoxes[2].text;
        //civilian branch text box
        branchTextBoxes[6].text = textBoxes[0].text;
        branchTextBoxes[7].text = textBoxes[1].text;
        branchTextBoxes[8].text = textBoxes[2].text;

    }
}
