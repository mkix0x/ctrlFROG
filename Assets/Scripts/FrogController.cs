using UnityEngine;

internal class FrogController : MonoBehaviour
{
    private IMover mover;

    private void Awake()
    {
        mover = GetComponent<IMover>();
    }

    private void Update()
    {
        Vector3 inputDirection = new(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        mover.Move(inputDirection);
    }
}