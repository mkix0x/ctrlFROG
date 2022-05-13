using UnityEngine;

internal interface IMover
{
    void Move(Vector3 direction);
}

internal class Mover : MonoBehaviour, IMover
{
    [SerializeField]
    private float moveSpeed = 4;
    
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        Vector3 velocity = direction.normalized * moveSpeed;
        body.velocity = new Vector3(velocity.x, body.velocity.y, velocity.z);
    }
}