using System;
using UnityEngine;

internal class GroundDetector : MonoBehaviour
{
    public bool IsGrounded = true;

    private void Update()
    {
        if (!IsGrounded && transform.position.y <= 0.1f)
        {
            IsGrounded = true;
            Landed?.Invoke();
        }

        if (IsGrounded && transform.position.y > 0.1f)
        {
            IsGrounded = false;
            LeftGround?.Invoke();
        }
    }

    public event Action Landed;
    public event Action LeftGround;
}