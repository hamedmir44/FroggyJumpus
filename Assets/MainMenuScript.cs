using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   public void playGame()
   {
      SceneManager.LoadSceneAsync("Main Game");
   }

   public void quitGame()
   {
      Application.Quit();
   }
}
   