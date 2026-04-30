using UnityEngine;

public class MenuFollowPlayer : MonoBehaviour
{
    public Transform centerEyeAnchor; // Die Brille
    public float distanceFromPlayer = 0.5f;
    public float heightOffset = -0.4f;

    void Update()
    {
        // 1. Position berechnen: Augenhöhe nehmen und Höhe für Hüfte abziehen
        Vector3 newPos = centerEyeAnchor.position;
        newPos.y += heightOffset;

        // 2. Den Anker vor den Spieler schieben
        Vector3 forward = centerEyeAnchor.forward;
        forward.y = 0; // Verhindert, dass das Menü in den Boden kippt
        newPos += forward.normalized * distanceFromPlayer;

        transform.position = newPos;

        // 3. Das Menü zum Spieler ausrichten (Y-Achse)
        transform.rotation = Quaternion.LookRotation(forward);
    }
}