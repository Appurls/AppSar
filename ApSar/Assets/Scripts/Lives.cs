using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] lives;

    public GameObject GameOver;
    public GameObject cieling;

    public GameObject Blur;

    public GameObject player;

    public Animator animat;
    
    public BoxCollider2D collider1;
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
        if(no_of_lives != 0){
            if(other.CompareTag("fruits")){
                Debug.Log("fruit touched floor");
                Debug.Log("no of lives left : " + no_of_lives);

                Destroy(lives[no_of_lives]);
                no_of_lives = no_of_lives -1;
                sfx.Play();

                
            }
        }
        else if (no_of_lives == 0){
            //game over
            Destroy(lives[no_of_lives]);
            animat.SetInteger("Lives",0);
            collider1.size = new Vector2(1, 0.2f);

            
            cieling.GetComponent<FruitDropper>().spawn_fruits = false;
            player.GetComponent<Moving>().enabled = false;
            Blur.SetActive(true);
            

            GameOver.SetActive(true);
            Debug.Log("Game Over");
        }
    }
}
