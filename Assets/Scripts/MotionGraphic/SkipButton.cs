using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;


public class SkipButton : MonoBehaviour
{
    [SerializeField] private GameObject skip;
    [SerializeField] private GameObject video;
    [SerializeField] private GameObject mandateParent;
    [SerializeField] private GameObject mandate1;
    [SerializeField] private GameObject mandate2;
    [SerializeField] private GameObject mandate3;
    [SerializeField] private GameObject mandate4;
    [SerializeField] private GameObject mandate5;
    [SerializeField] private GameObject earth;

    public void SkipToMandates()
    {
        skip.transform.DOScale(Vector3.zero, 1f).SetEase(Ease.OutExpo);
        video.transform.DOScale(Vector3.zero, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
        {
            earth.transform.localScale = Vector3.zero;
            mandateParent.SetActive(true);

            earth.transform.DOScale(Vector3.one * 0.93f, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
            {
                earth.transform.DOScale(Vector3.one * 0.856f, 0.5f).SetEase(Ease.InExpo).OnComplete(() =>
                {
                    mandate1.transform.localScale = Vector3.zero;
                    mandate2.transform.localScale = Vector3.zero;
                    mandate3.transform.localScale = Vector3.zero;
                    mandate4.transform.localScale = Vector3.zero;
                    mandate5.transform.localScale = Vector3.zero;
                    
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
                                
                                mandate4.SetActive(true);
                                mandate4.transform.DOScale(Vector3.one * 1.2f, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
                                {
                                    mandate4.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.InExpo);
                                    
                                    mandate5.SetActive(true);
                                    mandate5.transform.DOScale(Vector3.one * 1.2f, 0.5f).SetEase(Ease.OutExpo).OnComplete(
                                        () =>
                                        {
                                            mandate5.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.InExpo);
                                        });
                                });
                            });
                        });
                    });
                });
            });
            
            
        });
    }
}
