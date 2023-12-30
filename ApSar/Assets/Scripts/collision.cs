using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class collision : MonoBehaviour

{
    // public TextMeshProUGUI txt;
    //  private int score = 0;
  
   
    void  Awake() {


        
        
    }
    // Start is called before the first frame update
    void Start()

    {
        // GameObject textObject = GameObject.Find("Score_value");

        // txt = textObject.GetComponent<TextMeshProUGUI>();
       
        
    }

    // Update is called once per frame
    void Update()

    {
        
    }

   private void OnTriggerEnter2D(Collider2D other)
   
    {
         
       //Debug.Log("collison detected");
        // Check if the collided object has the "Player" tag
        if (other.CompareTag("main_character"))
        {
            // Perform actions specific to the player (optional)
            // Debug.Log("Fruit touched the player!");
            // score = score+1;
            
            // txt.text = ""+score;
            // Debug.Log("Score is: " + score);
           

            // Destroy the fruit GameObject when it collides with the player
            Destroy(gameObject);
        }
        if (other.CompareTag("floor")){
             Destroy(gameObject);

        }

        if (other.CompareTag("walls")){
             Destroy(gameObject);

        }
    }
}
