using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void PlaySound(AudioClip clip)
    {

        AudioSource audioSource = new GameObject("TempAudioSource").AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();

        Destroy(audioSource.gameObject, clip.length);
    }
}
