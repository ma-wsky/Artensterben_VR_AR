using UnityEngine;

public class ButtonTeleport : MonoBehaviour
{
    // Das ist die Kamera/der Spieler, der bewegt werden soll
    public GameObject playerCameraRig;

    // Die Ziel-Koordinaten
    public Vector3 targetPosition;

    // Diese Funktion rufen wir auf, wenn der Button gedrückt wird
    public void TeleportPlayer()
    {
        if (playerCameraRig != null)
        {
            playerCameraRig.transform.position = targetPosition;
        }
    }
}