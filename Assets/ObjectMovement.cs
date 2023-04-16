using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObjectMovement : MonoBehaviour
{
    // Set the boundary of the movement
    public float boundaryLeft = -2.5f;
    public float boundaryRight = 2.5f;
    public float boundaryTop = 4.5f;
    public float boundaryBottom = -4.5f;

    // Set the starting position of the object
    private Vector3 startPosition;

    // Set the movement speed of the object
    public float moveSpeed = 5f;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        // Move the object
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // Check if the object hits the boundary and return to the starting point
        if (transform.position.x > boundaryRight  transform.position.x < boundaryLeft
            transform.position.y > boundaryTop || transform.position.y < boundaryBottom);
        {
            transform.position = startPosition;

            // Move to the next scene when the object reaches the end of the boundary
            if (SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene().buildIndex + 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}



