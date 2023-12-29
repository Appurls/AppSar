using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

     public float moveSpeed = 9f; 
     public Animator animator;
     public SpriteRenderer sr;

     private Rigidbody2D rb;
     public BoxCollider2D cl;
     public GameObject AttackPlayer;
      public GameObject RunPlayer;

     public AudioClip Run;
     public AudioClip Attack;
     private Boolean isplaying;
 
     
     


     public float attackDuration = 0.01f;
    // Start is called before the first frame update
    void Start()

    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Left mouse button is clicked
            AudioSource AS = AttackPlayer.GetComponent<AudioSource>();

           AS.clip = Attack;
           AS.Play();

            animator.SetBool("Attack" , true);
            Debug.Log("mouse pressesd");
            cl.size = new Vector2(2,1);
           
        
            


            Invoke("ResetAttackAnimation", attackDuration);
   

            // Perform your actions or trigger events here
        }
       
     
         // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");

        if(horizontalInput != 0){
            if(!isplaying){
             AudioSource AS = RunPlayer.GetComponent<AudioSource>();
            AS.clip = Run;
            AS.Play();
            isplaying = true;
            }
        }
        else{
            AudioSource AS = RunPlayer.GetComponent<AudioSource>();
            AS.clip = Run;
            AS.Stop();
            isplaying = false;

        }
        if(horizontalInput > 0){
            sr.flipX = true;
        }
        else{
            sr.flipX = false;
        }
        //Debug.Log(horizontalInput);
        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // Move the object based on input
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        
        
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an object tagged as "Wall"
        if (collision.gameObject.CompareTag("walls"))
        {
            // Stop player movement
            rb.velocity = Vector2.zero;
        }
    }
     void ResetAttackAnimation()
    {
        // Reset the "Attack" parameter after the attack duration
        animator.SetBool("Attack", false);
        cl.size = new Vector2(1,1);
    }
    
}


