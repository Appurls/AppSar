using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void loadscene(){
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void quitGame(){
        Application.Quit();
    }
}
