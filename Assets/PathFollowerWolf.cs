using UnityEngine;

public class PathFollowerWolf : MonoBehaviour
{
    public Transform[] waypoints;
    public float walkSpeed = 1.5f;
    public float rotationSpeed = 5.0f;
    public float waitTime = 2.0f;
    public float arrivalDistance = 0.5f;

    [Header("Ground Settings")]
    public LayerMask groundLayer; // Stelle das auf "Default" oder deinen Boden-Layer
    public float raycastDistance = 2.0f; // Wie tief soll er nach Boden suchen?
    public float heightOffset = 0.0f;   // Falls das Tier zu tief im Boden steckt

    private int currentPointIndex = 0;
    private bool isWaiting = false;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (waypoints.Length == 0 || isWaiting) return;

        Transform target = waypoints[currentPointIndex];

        // 1. Richtung bestimmen (X und Z)
        Vector3 direction = target.position - transform.position;
        direction.y = 0;

        float distance = direction.magnitude;

        if (distance < arrivalDistance)
        {
            StartCoroutine(ReachPoint());
            return;
        }

        // 2. Drehen
        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        // 3. Laufen
        anim.SetBool("isWalking", true);

        // Bewege das Tier vorwärts
        Vector3 moveStep = transform.forward * walkSpeed * Time.deltaTime;
        transform.position += moveStep;

        // 4. Bodenhaftung (Raycast nach unten)
        FixHeight();
    }

    void FixHeight()
    {
        // Wir schießen einen Strahl von etwas oberhalb des Tieres nach unten
        Vector3 rayStart = transform.position + Vector3.up * 1.0f;
        RaycastHit hit;

        if (Physics.Raycast(rayStart, Vector3.down, out hit, raycastDistance + 1.0f, groundLayer))
        {
            // Setze die Y-Position exakt auf den Treffpunkt des Bodens
            Vector3 newPos = transform.position;
            newPos.y = hit.point.y + heightOffset;
            transform.position = newPos;

            // Optional: Das Tier an die Schräge des Bodens anpassen
            // transform.up = Vector3.Slerp(transform.up, hit.normal, Time.deltaTime * 5f);
        }
    }

    System.Collections.IEnumerator ReachPoint()
    {
        isWaiting = true;
        anim.SetBool("isWalking", false);
        yield return new WaitForSeconds(waitTime);
        currentPointIndex = (currentPointIndex + 1) % waypoints.Length;
        isWaiting = false;
    }

    private void OnDrawGizmos()
    {
        // (Dein bisheriger Gizmo-Code bleibt gleich)
        if (waypoints == null || waypoints.Length < 2) return;
        Gizmos.color = Color.yellow;
        for (int i = 0; i < waypoints.Length; i++)
        {
            if (waypoints[i] != null)
            {
                Gizmos.DrawSphere(waypoints[i].position, 0.3f);
                if (i < waypoints.Length - 1 && waypoints[i + 1] != null)
                    Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
            }
        }
    }
}