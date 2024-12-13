using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int requiredScore = 6;
    public string nextSceneName = "";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MovementController playerController = other.GetComponent<MovementController>();

            if (playerController != null)
            {
                if (playerController.score >= requiredScore)
                {
                    SceneManager.LoadScene(nextSceneName);
                }
                else
                {
                    Debug.Log("Nie masz wystarczajacej liczby punktow, aby przejsc dalej.");
                }
            }
        }
    }
}
