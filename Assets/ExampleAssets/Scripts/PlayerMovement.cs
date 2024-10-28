using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput;
    private float forwardInput;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void moveUp()
    {
        horizontalInput = 0; forwardInput = -5;
    }

    public void moveDown()
    {
        horizontalInput = 0; forwardInput = 5;
    }

    public void moveRight()
    {
        horizontalInput = -5; forwardInput = 0;

    }

    public void moveLeft()
    {
        horizontalInput = 5; forwardInput = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        horizontalInput = 0; forwardInput = 0;
    }
}
