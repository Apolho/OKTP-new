using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SkipButton : MonoBehaviour
{
    [SerializeField] private GameObject skip;
    [SerializeField] private GameObject video;
    [SerializeField] private GameObject mandateParent;
    [SerializeField] private GameObject mandate1;
    [SerializeField] private GameObject mandate2;
    [SerializeField] private GameObject mandate3;
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject earth;
    [SerializeField] private Image waveV;
    [SerializeField] private GameObject chapter1;

    public bool VideoCount;
    public float timer;

    public void SkipToMandates()
    {
        skip.transform.DOScale(Vector3.zero, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
        {
            skip.SetActive(false);
        });
        video.SetActive(false);
        waveV.transform.DOMoveY(500f, 2f).OnComplete(() =>
        {
            chapter1.transform.localScale = Vector3.zero;
            chapter1.SetActive(true);
            chapter1.transform.DOScale(Vector3.one, 1f).OnComplete(() =>
            {
                Invoke("DisplayConflicts",1.5f);
            });
        });
        
    }

    private void DisplayConflicts()
    {
        chapter1.transform.DOScale(Vector3.zero, 0.3f).OnComplete(() =>
        {
            chapter1.SetActive(false);
            waveV.transform.DOMoveY(-1000f, 2f).OnComplete(() =>
            {
                earth.transform.localScale = Vector3.zero;
                earth.SetActive(true);

                earth.transform.DOScale(Vector3.one * 0.93f, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
                {
                    earth.transform.DOScale(Vector3.one * 0.856f, 0.5f).SetEase(Ease.InExpo).OnComplete(() =>
                    {
                        mandate1.transform.localScale = Vector3.zero;
                        mandate2.transform.localScale = Vector3.zero;
                        mandate3.transform.localScale = Vector3.zero;
                    
                        text.SetActive(true);
                        mandate1.SetActive(true);
                        mandate1.transform.DOScale(Vector3.one * 1.2f, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
                        {
                            mandate1.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.InExpo);
                        
                            mandate2.SetActive(true);
                            mandate2.transform.DOScale(Vector3.one * 1.2f, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
                            {
                                mandate2.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.InExpo);
                            
                                mandate3.SetActive(true);
                                mandate3.transform.DOScale(Vector3.one * 1.2f, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
                                {
                                    mandate3.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.InExpo);
                                });
                            });
                        });
                    });
                });
            });
        });
    }

    private void Update()
    {
        if (VideoCount)
        {
            timer += Time.deltaTime;
        }

        if (timer > 60f)
        {
            timer = 0;
            VideoCount = false;
            SkipToMandates();
        }
    }
}
