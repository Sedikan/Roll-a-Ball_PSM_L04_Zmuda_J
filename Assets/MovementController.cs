using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour

{
    public int score;
    public float moveSpeed = 5f;
    public float scaleSpeed = 0.5f;
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
        if (score >= 6)
        {
            Debug.Log("Wygra³eœ!!!");
        }
        if (Input.GetKey(KeyCode.T))
        { transform.localScale += Vector3.one * -scaleSpeed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.G))
        { transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime; }

        if (transform.localScale.x < 0.1f) {
            { transform.localScale = new Vector3(0.1f, 0.1f, 0.1f); }

        }
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
    public void CollectScore()
    {
        score += 1;
        Debug.Log("Zdoby³eœ punkt, masz ich teraz " + score);
    }
    

}