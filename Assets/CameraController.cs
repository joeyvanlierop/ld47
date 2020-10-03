using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    private Camera cameraComponent;
    private float endSize = 1.032747f;


    void Awake()
    {
        cameraComponent = GetComponent<Camera>();
        cameraComponent.orthographicSize = 2.175419f;
        // Resize();
    }

    void Update() {
        cameraComponent.orthographicSize = Mathf.Lerp(cameraComponent.orthographicSize, endSize, Time.deltaTime * 1.2f);
    }

    // void Resize()
    // {
    //     cameraComponent = GetComponent<Camera>();
    //     Debug.Log("hello");
    // }
}
