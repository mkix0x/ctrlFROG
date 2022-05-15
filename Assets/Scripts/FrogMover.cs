using UnityEngine;

internal class FrogMover : MonoBehaviour, IMover
{
    public float GroundSpeed = 4;

    public float AirSpeed = 6;

    private Rigidbody body;
    private GroundDetector groundDetector;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        groundDetector = GetComponent<GroundDetector>();
    }

    public void Move(Vector3 direction)
    {
        float moveSpeed = groundDetector.IsGrounded ? GroundSpeed : AirSpeed;
        Vector3 velocity = direction.normalized * moveSpeed;
        body.velocity = new Vector3(velocity.x, body.velocity.y, velocity.z);
    }
}