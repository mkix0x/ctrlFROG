using UnityEngine;

internal class AutoJumper : MonoBehaviour
{
    [SerializeField]
    private float cooldown;

    private float nextJumpTime;
    private Rigidbody body;

    [SerializeField]
    private float jumpForce = 5;

    private GroundDetector groundDetector;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        groundDetector = GetComponent<GroundDetector>();
        nextJumpTime = Time.time + cooldown;
    }

    private void Update()
    {
        if (nextJumpTime > Time.time)
            return;

        if (!groundDetector.IsGrounded)
            return;

        nextJumpTime = Time.time + cooldown;
        Jump();
    }

    private void Jump()
    {
        Vector3 velocity = body.velocity;
        velocity.y = jumpForce;
        body.velocity = velocity;
    }
}