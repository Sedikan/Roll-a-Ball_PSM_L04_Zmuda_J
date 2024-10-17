using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(40 * Time.deltaTime, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player")) 
        {
            other.gameObject.GetComponent<MovementController>().score += 1;
            Debug.Log("Zdoby³eœ punkt! \n Score: " + score);
            gameObject.SetActive(false);
            
        }
    
    }

}