using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class LearnMoreButton : MonoBehaviour
{
    [SerializeField] private GameObject poeple;
    [SerializeField] private GameObject qrcode;
    [SerializeField] private TextMeshProUGUI congrats;
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private List<GameObject> Circles;
    [SerializeField] private List<GameObject> people;

    public List<Vector3> endPos;
    public List<Vector3> peoplePos;

    public void LearnMore()
    {
        for (int i = 0; i < Circles.Count; i++)
        {
            
            Circles[i].transform.position = Vector3.down * 3;
        }

        foreach (var person in people)
        {
            person.GetComponent<SpriteRenderer>().DOFade(1, 0.1f);
            person.transform.localScale = Vector3.one * 0.3f;
            person.transform.position = Vector3.down * 3f;
        }
        
        poeple.SetActive(true);

        for (int i = 0; i < Circles.Count; i++)
        {
            
            Circles[i].transform.DOMove(endPos[i], 2f);
        }

        congrats.DOFade(0, 3f);
        title.DOFade(0, 3f);
        
        qrcode.GetComponent<SpriteRenderer>().DOFade(0, 0.1f);
        
        Invoke("QRcode",3f);

        for (int i = 0; i < people.Count; i++)
        {
            people[i].transform.DOScale(Vector3.one * 0.5f, 2f);
            people[i].transform.DOMove(peoplePos[i], 2f).OnComplete(() =>
            {
                people[i].GetComponent<SpriteRenderer>().DOFade(0, 1f);
            });
        }
        
        this.gameObject.SetActive(false);
    }

    private void QRcode()
    {
        poeple.SetActive(false);
        
        qrcode.SetActive(true);

        qrcode.GetComponent<SpriteRenderer>().DOFade(1, 3f);

        congrats.text = null;
        congrats.text = null;

        //this.gameObject.SetActive(false);

    }
}
