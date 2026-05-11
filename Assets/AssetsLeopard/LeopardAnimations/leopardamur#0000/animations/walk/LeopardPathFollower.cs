using UnityEngine;

public class LeopardPathFollower : MonoBehaviour
{
    public Transform[] waypoints;
    public float walkSpeed = 1.5f;
    public float rotationSpeed = 5.0f;
    public float waitTime = 2.0f;

    // WICHTIG: Erhöhe diesen Wert, wenn er um den Punkt kreist!
    public float arrivalDistance = 0.5f;

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

        // 1. Richtung bestimmen
        Vector3 direction = target.position - transform.position;
        direction.y = 0; // Wir ignorieren die Höhe

        // 2. Distanz prüfen
        float distance = direction.magnitude;

        // Wenn er nah genug dran ist -> Punkt erreicht!
        if (distance < arrivalDistance)
        {
            StartCoroutine(ReachPoint());
            return;
        }

        // 3. Drehen
        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        // 4. Laufen (nur wenn er nicht wartet)
        anim.SetBool("isWalking", true);
        transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
    }

    System.Collections.IEnumerator ReachPoint()
    {
        isWaiting = true;
        anim.SetBool("isWalking", false);

        // Kleine Sicherheit: Wir setzen die Position kurz exakt auf den Punkt
        // damit er beim nächsten Start eine saubere Richtung hat
        // transform.position = new Vector3(waypoints[currentPointIndex].position.x, transform.position.y, waypoints[currentPointIndex].position.z);

        yield return new WaitForSeconds(waitTime);

        currentPointIndex = (currentPointIndex + 1) % waypoints.Length;
        isWaiting = false;
    }


private void OnDrawGizmos()
    {
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