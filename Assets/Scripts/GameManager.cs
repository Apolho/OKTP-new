using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI[] textBoxes;

    public GameObject continueButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < textBoxes.Length; i++)
        {
            if (textBoxes[2].gameObject.CompareTag("Selected"))
            {
                continueButton.SetActive(true);
            }
        }
    }
}
