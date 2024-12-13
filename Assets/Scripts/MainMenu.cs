using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsPanel;
    public GameObject Menu;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowOptions()
    {
        OptionsPanel.SetActive(true);
        Menu.SetActive(false);
    }

    public void HideOptions()
    {
      OptionsPanel.SetActive(false);
    Menu.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
