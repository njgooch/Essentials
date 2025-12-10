using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class InitialVelocity : MonoBehaviour
{
    [Header("Initial Velocity Settings")]
    [Tooltip("The initial velocity applied when the object spawns.")]
    public Vector3 initialVelocity = new Vector3(0f, -5f, 0f);

    [Tooltip("If true, velocity is applied in local space (relative to the object's rotation).")]
    public bool useLocalSpace = false;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (useLocalSpace)
        {
            rb.linearVelocity = transform.TransformDirection(initialVelocity);
        }
        else
        {
            rb.linearVelocity = initialVelocity;
        }
    }
}
