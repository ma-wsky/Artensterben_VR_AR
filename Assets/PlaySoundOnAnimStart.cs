using UnityEngine;

public class PlaySoundOnAnimStart : StateMachineBehaviour
{
    public AudioClip soundClip;
    [Range(0, 1)] public float volume = 1f;

    [Tooltip("Bei wie viel Prozent der Animation soll der Sound spielen? (0.0 bis 1.0)")]
    [Range(0, 1)] public float playAtNormalizedTime = 0.2f;

    private bool hasPlayedThisLoop = false;
    private float lastNormalizedTime = 0f;

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float currentTime = stateInfo.normalizedTime % 1f;

        // Falls die Animation neu geloopt hat (Zeit springt von fast 1 auf fast 0)
        if (currentTime < lastNormalizedTime)
        {
            hasPlayedThisLoop = false;
        }

        // Wenn wir den gewünschten Zeitpunkt erreicht haben und noch nicht gespielt haben
        if (!hasPlayedThisLoop && currentTime >= playAtNormalizedTime)
        {
            PlaySound(animator);
            hasPlayedThisLoop = true;
        }

        lastNormalizedTime = currentTime;
    }

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Reset für den ersten Start
        hasPlayedThisLoop = false;
        lastNormalizedTime = 0f;
    }

    private void PlaySound(Animator animator)
    {
        AudioSource audioSource = animator.GetComponent<AudioSource>();
        if (audioSource == null) audioSource = animator.GetComponentInChildren<AudioSource>();

        if (audioSource != null && soundClip != null)
        {
            audioSource.PlayOneShot(soundClip, volume);
        }
    }
}