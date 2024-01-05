using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision2 : MonoBehaviour
{   
    public TextMeshProUGUI text;

   
    

    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        
    }

    // Update is called once per frame
    void Update()

    {
        if (score > 20){
            Scene currentScene = SceneManager.GetActiveScene();

            if(currentScene.name.Equals("level_1")){
                SceneManager.LoadScene("level_2");
            }

        }
           
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("fruits")){

            Debug.Log("Touched a fruit");
            score+= 2;
            text.text = "" + score;
            Debug.Log("Score is : " + score);

            /// this part is for missed fruits
            
            


        }


    }
}
