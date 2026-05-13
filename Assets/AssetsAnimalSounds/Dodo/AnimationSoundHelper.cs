using UnityEngine;

public class AnimationSoundHelper : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Diese Funktion wird vom Animation Event aufgerufen
    public void PlayAnimationSound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}