using UnityEngine;

internal class AutoJumper : MonoBehaviour
{
    public float Cooldown;

    public float JumpForce = 5;

    private Rigidbody body;

    private GroundDetector groundDetector;

    private float nextJumpTime;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        groundDetector = GetComponent<GroundDetector>();
        nextJumpTime = Time.time + Cooldown;
    }

    private void Update()
    {
        if (nextJumpTime > Time.time)
            return;

        if (!groundDetector.IsGrounded)
            return;

        nextJumpTime = Time.time + Cooldown;
        Jump();
    }

    private void Jump()
    {
        Vector3 velocity = body.velocity;
        velocity.y = JumpForce;
        body.velocity = velocity;
    }
}