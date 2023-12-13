using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class wave : MonoBehaviour
{
    [SerializeField] private GameObject chapter2;
    void Start()
    {
        chapter2.transform.localScale = Vector3.zero;
        chapter2.transform.DOScale(Vector3.one,1f).SetEase(Ease.InExpo).OnComplete((() =>
        {
            Invoke("ShowNew",1.5f);
        }));
        
    }

    private void ShowNew()
    {
        chapter2.transform.DOScale(Vector3.zero, 0.3f).OnComplete(() =>
        {
            chapter2.SetActive(false);
            transform.DOMoveX(3200f, 4f).SetEase(Ease.OutFlash).OnComplete(() =>
            {
                gameObject.SetActive(false);
            });
        });

    }

    
}
