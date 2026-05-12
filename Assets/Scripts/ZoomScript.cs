using UnityEngine;
using UnityEngine.InputSystem;

public class ZoomScript : MonoBehaviour
{

    [SerializeField] private float zoomFOV;
    [SerializeField] private float normalFOV;
    [SerializeField] private float zoomSpeed;

    private Camera Camera;

    void Start()
    {
        Camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    public void Update()
    {
        float targetFOV = Input.GetKey(KeyCode.Mouse0) ? zoomFOV: normalFOV;

        Camera.fieldOfView = Mathf.Lerp(Camera.fieldOfView, targetFOV, Time.deltaTime * zoomSpeed);
    }
}
