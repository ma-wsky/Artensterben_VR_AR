using UnityEngine;

public class HandMenuController : MonoBehaviour
{
    public GameObject menuAnchor;     // Dein MenuAnchor Objekt
    public Transform handTransform;  // Die linke Hand (z.B. Hand_L)
    public Transform headTransform;  // Dein CenterEyeAnchor

    [Range(-1, 1)]
    public float threshold = 0.7f;   // Wie genau man die Hand anschauen muss

    void Update()
    {
        // Wir berechnen, ob die Handfläche zum Kopf zeigt
        // Das Skalarprodukt (Dot Product) hilft uns hier
        Vector3 handFacing = handTransform.up; // Bei Meta-Händen zeigt 'up' oft aus der Fläche
        Vector3 toHead = (headTransform.position - handTransform.position).normalized;

        float dot = Vector3.Dot(handFacing, toHead);

        // Wenn die Hand zum Kopf zeigt, aktiviere das Menü
        if (dot < threshold)
        {
            if (!menuAnchor.activeSelf) menuAnchor.SetActive(true);
        }
        else
        {
            if (menuAnchor.activeSelf) menuAnchor.SetActive(false);
        }
    }
}