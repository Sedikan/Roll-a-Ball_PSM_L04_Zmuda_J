using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int score = 1;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        RotateCollectible();
      
    }

    private void RotateCollectible()
    {
        transform.Rotate(40 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Collect(other);
        }
    }

    private void Collect(Collider player)
    {
        player.gameObject.GetComponent<MovementController>().CollectScore();
        Debug.Log("Zdoby³eœ punkt!");

        PlayCollectSound();

        gameObject.SetActive(false);
    }

    private void PlayCollectSound()
    {
        audioSource.Play(); 
    }

}
