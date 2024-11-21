using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{
    public int score;
    public float moveSpeed = 5f;
    public float scaleSpeed = 0.5f;
    public Text scoreText;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UpdateScoreText();
    }

    void FixedUpdate()
    {
        Move();

        HandleScaling();
 
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
    }

    void HandleScaling()
    {
        if (Input.GetKey(KeyCode.T))
        {
            transform.localScale += Vector3.one * -scaleSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }

        if (transform.localScale.x < 0.1f)
        {
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
    }

    public void CollectScore()
    {
        score += 1;
        Debug.Log("Zdoby³eœ punkt, masz ich teraz " + score);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
