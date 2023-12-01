using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float amplitude = 1.0f;   // Adjust this value to change the movement range
    public float speed = 2.0f;   
     public float forwardSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
         float newY = Mathf.Sin(Time.time * speed) * amplitude;

        // Update the object's position
        transform.position = new Vector2(transform.position.x, newY);
         transform.Translate(Vector2.right * forwardSpeed * Time.deltaTime);
    }
}
