using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour

{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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
