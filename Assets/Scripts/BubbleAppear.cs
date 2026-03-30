using UnityEngine;

public class BubbleAppear : MonoBehaviour
{
    Camera Cam;

    public Transform ButtonPos;

    RectTransform BubbleRect;

    Canvas inspectCanvas;

    private void Start()
    {
        Cam = this.GetComponentInParent<Camera>();
        BubbleRect = this.GetComponent<RectTransform>();
        inspectCanvas = this.GetComponentInParent<Canvas>();
    }
    // Update is called once per frame
    void Update()
    {
        BubbleRect.anchoredPosition = Cam.WorldToScreenPoint(ButtonPos.position);
    }
}
