using UnityEngine;

internal class Rotator : MonoBehaviour
{
    public void RotateTowards(Vector3 point)
    {
        Vector3 lookDirection = point - transform.position;
        lookDirection.Normalize();

        float angle = Mathf.Atan2(lookDirection.z, lookDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, -angle, 0);
    }
}