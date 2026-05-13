using UnityEngine;

public class ButtonTeleport : MonoBehaviour
{
    public GameObject playerCameraRig;
    public GameObject destination;

    [Header("Ambient Sound Settings")]
    [Tooltip("Die AudioSource, die die Hintergrundmusik/Atmo abspielt (sollte auf 2D stehen).")]
    public AudioSource globalAmbienceSource; 
    
    [Tooltip("Der Soundclip, der nach dem Teleport starten soll.")]
    public AudioClip newAmbientSound;

    public void TeleportPlayer()
    {
        if (playerCameraRig != null && destination != null)
        {
            // 1. Spieler teleportieren
            playerCameraRig.transform.position = destination.transform.position;
            playerCameraRig.transform.rotation = destination.transform.rotation;
            
            // 2. Sound umschalten
            HandleAmbience();

            Debug.Log("Teleport zu " + destination.name + " erfolgreich!");
        }
        else
        {
            if (playerCameraRig == null) Debug.LogError("PlayerRig fehlt!");
            if (destination == null) Debug.LogError("Destination (Empty) fehlt!");
            Debug.LogError("Fehler bei Button: " + gameObject.name + " - Target fehlt!");
        }
    }

    private void HandleAmbience()
    {
        if (globalAmbienceSource != null)
        {
            // FALL 1: Ein neuer Sound wurde im Inspector zugewiesen
            if (newAmbientSound != null)
            {
                // Nur umschalten, wenn es nicht schon derselbe Clip ist
                if (globalAmbienceSource.clip != newAmbientSound)
                {
                    globalAmbienceSource.Stop();
                    globalAmbienceSource.clip = newAmbientSound;
                    globalAmbienceSource.loop = true;
                    globalAmbienceSource.Play();
                    Debug.Log("Neuer Ambient Sound gestartet: " + newAmbientSound.name);
                }
            }
            // FALL 2: Das Feld 'newAmbientSound' ist leer
            else
            {
                globalAmbienceSource.Stop();
                globalAmbienceSource.clip = null; // Entfernt den alten Clip
                Debug.Log("Umgebungssound gestoppt (kein Clip angegeben).");
            }
        }
    }
}