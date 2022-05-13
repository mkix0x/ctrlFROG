using UnityEngine;

class LookAtMouse : MonoBehaviour
{
    private new Camera camera;
    private Rotator rotator;

    private void Awake()
    {
        rotator = GetComponent<Rotator>();
    }

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        Ray cameraRay = camera.ScreenPointToRay(Input.mousePosition);

        if (!Physics.Raycast(cameraRay, out RaycastHit hit))
            return;

        rotator.RotateTowards(hit.point);
    }
}