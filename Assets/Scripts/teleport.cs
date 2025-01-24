using UnityEngine;

public class TeleportOnTouch : MonoBehaviour
{
    public Transform teleportPoint;
    public string targetTag = "TeleportTrigger";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(targetTag))
        {
            Transform playerTransform = collision.collider.transform;
            playerTransform.position = teleportPoint.position;
        }
    }
}
