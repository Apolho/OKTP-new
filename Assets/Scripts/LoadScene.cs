using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   public string sceneName;

   public void ChangeScene()
   {
      SceneManager.LoadScene(sceneName);
   }
}
