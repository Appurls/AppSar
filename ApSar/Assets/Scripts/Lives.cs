using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] lives;
    private int no_of_lives = 3;
    public AudioSource sfx;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(no_of_lives != -1){
            if(other.CompareTag("fruits")){
                Debug.Log("fruit touched floor");
                Debug.Log("no of lives left : " + no_of_lives);

                Destroy(lives[no_of_lives]);
                no_of_lives = no_of_lives -1;
                sfx.Play();

                
            }
        }
        else{
            //game over
        }
    }
}
