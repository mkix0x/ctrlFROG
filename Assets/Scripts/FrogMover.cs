using UnityEngine;

class FrogMover : MonoBehaviour, IMover
{
    [SerializeField]
    private float groundSpeed = 4;
    
    [SerializeField]
    private float airSpeed = 6;
    
    private Rigidbody body;
    private GroundDetector groundDetector;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        groundDetector = GetComponent<GroundDetector>();
    }
    
    public void Move(Vector3 direction)
    {
        float moveSpeed = groundDetector.IsGrounded ? groundSpeed : airSpeed;
        Vector3 velocity = direction.normalized * moveSpeed;
        body.velocity = new Vector3(velocity.x, body.velocity.y, velocity.z);
    }
}