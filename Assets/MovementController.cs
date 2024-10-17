using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public int score = 0;
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

       
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward * moveSpeed);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back * moveSpeed);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left * moveSpeed);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * moveSpeed);
                                                        //float moveX = Input.GetAxis("Horizontal");
                                                        //float moveY = Input.GetAxis("Vertical");

                                                        //Vector3 move = new Vector3(moveX, 0, moveY);
                                                        //rb.AddForce(move * moveSpeed);
    }

  
}