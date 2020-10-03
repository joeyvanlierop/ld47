using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    private Camera cameraComponent;

    void Awake()
    {
        Resize();
    }

    void Resize()
    {
        cameraComponent = GetComponent<Camera>();
    }
}
