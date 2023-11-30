using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MandateSelect : MonoBehaviour
{
    public TextMeshProUGUI[] mandate;
    public TextMeshProUGUI mandateButton;
    public GameObject feedBack;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MandateSelected()
    {
        //mandate = new TextMeshProUGUI[2];
        for (int i = 0; i < mandate.Length; i++)
        {
            if (mandate[i].gameObject.CompareTag("Selected"))
            {
                continue;
            }
            else
            {
                mandate[i].text = mandateButton.text;
                mandate[i].gameObject.tag = "Selected";
                return;
            }
            
        }
    }

    public void WrongMandate()
    {
        feedBack.SetActive(true);
    }
}
