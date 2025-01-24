using UnityEngine;

public class CameraLevel3 : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;   
    public float smoothSpeed = 0.125f;

    private Transform GetTransform()
    {
        return transform;
    }

    void LateUpdate(Transform transform)
    {
       
        Vector3 desiredPosition = player.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
