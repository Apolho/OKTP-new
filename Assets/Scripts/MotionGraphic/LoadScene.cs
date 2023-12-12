using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

   public int counter;

   
   public void ChangeScene()
   {
      if (counter < 2)
      {
         counter++;
      }
      else if (counter == 2)
      {
         SceneManager.LoadScene("Referendum");
      }
   }
}
