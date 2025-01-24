using UnityEngine;

public class ObracajObiekt : MonoBehaviour
{
    public float predkoscObrotu = 50f; // Szybkość obrotu w stopniach na sekundę

    void Update()
    {
        // Obrót obiektu wokół osi Y
        transform.Rotate(0, predkoscObrotu * Time.deltaTime, 0);
    }
}
