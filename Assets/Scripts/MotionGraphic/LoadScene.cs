using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
   [SerializeField] private GameObject one;
   [SerializeField] private GameObject two;
   [SerializeField] private GameObject three;
   [SerializeField] private Image wave;
   public int counter;

   
   public void ChangeScene()
   {
      switch (counter)
      {
         case 0:
            one.SetActive(true);
            break;
         case 1:
            one.SetActive(false);
            two.SetActive(true);
            break;
         case 2:
            two.SetActive(false);
            three.SetActive(true);
            break;
      }
      
      if (counter < 2)
      {
         counter++;
      }
      else if (counter == 2)
      {
         wave.transform.DOMoveX(1000f, 2f).SetEase(Ease.InFlash).OnComplete(() =>
         {
            SceneManager.LoadScene("Referendum");
         });
      }

      
   }
}
