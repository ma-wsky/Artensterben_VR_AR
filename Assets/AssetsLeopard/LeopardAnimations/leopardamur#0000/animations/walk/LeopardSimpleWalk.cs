using UnityEngine;

public class LeopardShowcaseWalker : MonoBehaviour
{
    private Animator anim;

    [Header("Bewegung")]
    public float walkSpeed = 1.5f;
    public float rotationSpeed = 40.0f; // Wie schnell er sich dreht (Grad pro Sekunde)

    [Header("Timing")]
    public float walkDuration = 5.0f;
    public float idleDuration = 2.0f;

    private float timer;
    private bool isWalking = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        timer = idleDuration;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            isWalking = !isWalking;
            timer = isWalking ? walkDuration : idleDuration;
            anim.SetBool("isWalking", isWalking);
        }

        if (isWalking)
        {
            // 1. Vorwärts bewegen
            transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);

            // 2. Rotieren (um die Y-Achse / nach links oder rechts)
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}