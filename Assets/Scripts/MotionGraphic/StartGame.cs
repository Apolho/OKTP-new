using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private SkipButton _skipButton;
    [SerializeField] private TextMeshProUGUI operation;
    [SerializeField] private TextMeshProUGUI keepthepeace;
    [SerializeField] private GameObject police;
    [SerializeField] private GameObject video;
    [SerializeField] private GameObject skip;
    //[SerializeField] private GameObject button;


    public void StartSceneAni()
    {
        operation.transform.DOMoveX(600f, 0.5f).SetEase(Ease.OutExpo).OnComplete((() =>
        {
            operation.transform.DOMoveX(300f, 2f).SetEase(Ease.OutExpo);
        }));

        keepthepeace.transform.DOMoveX(300f, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
        {
            keepthepeace.transform.DOMoveX(600f, 2f).SetEase(Ease.OutExpo);
        });
        
        Invoke("MovePolice",1f);
    }

    private void MovePolice()
    {
        police.transform.DOMoveY(0.1f, 0.5f).SetEase(Ease.OutExpo).OnComplete(() =>
        {
            police.transform.DOMoveY(-2f, 0.8f).SetEase(Ease.InCirc).OnComplete(() =>
            {
                operation.gameObject.SetActive(false);
                keepthepeace.gameObject.SetActive(false);
                police.SetActive(false);
                gameObject.SetActive(false);
                
                VideoComeIn();
            });
        });
    }

    private void VideoComeIn()
    {
        video.SetActive(true);
        skip.SetActive(true);
        _skipButton.VideoCount = true;
    }
}
