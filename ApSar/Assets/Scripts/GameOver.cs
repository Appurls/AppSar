using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.VisualScripting;

using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
   public void RestartGame()
    {
        SceneManager.LoadScene("level_1"); // Replace "YourGameScene" with the actual game scene name
    }

    public void Mainmenu(){
        SceneManager.LoadScene("Menu");
    }

  
}
