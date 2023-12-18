using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundloop : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed = 5f;
     float backgroundWidth = 49.5f;
    




    void Update()
    {
        // Move the background to the left
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // Check if the background needs to be reset
        if (transform.position.x < -backgroundWidth)
        {
            // Move the background to the right to create a loop
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        // Calculate the new position to place the background to the right of the current background
        Vector3 newPosition = new Vector3(49, -4, 0);

        // Move the background to the new position
        transform.position = newPosition;
    }
}


