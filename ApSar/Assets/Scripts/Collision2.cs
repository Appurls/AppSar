using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("fruits")){

            Debug.Log("Touched a fruit");
            score+= 1;
            text.text = "" + score;
            Debug.Log("Score is : " + score);

            /// this part is for missed fruits
            
            


        }


    }
}
