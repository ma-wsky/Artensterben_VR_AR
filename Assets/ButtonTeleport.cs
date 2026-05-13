using UnityEngine;

public class ButtonTeleport : MonoBehaviour
{
    public GameObject playerCameraRig;
    // Wir nennen es um, um Unity zum "Nachdenken" zu zwingen
    public GameObject destination;

    public void TeleportPlayer()
    {
        if (playerCameraRig != null && destination != null)
        {
            playerCameraRig.transform.position = destination.transform.position;
            playerCameraRig.transform.rotation = destination.transform.rotation;
            Debug.Log("Teleport zu " + destination.name + " erfolgreich!");
        }
        else
        {
            if (playerCameraRig == null) Debug.LogError("PlayerRig fehlt!");
            if (destination == null) Debug.LogError("Destination (Empty) fehlt!");
            Debug.LogError("Fehler bei Button: " + gameObject.name + " - Target fehlt!");
        }
    }
}