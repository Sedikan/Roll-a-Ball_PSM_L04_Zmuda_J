using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 kamera;
    void Start()
    {
        kamera = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - kamera ;
    }
}
