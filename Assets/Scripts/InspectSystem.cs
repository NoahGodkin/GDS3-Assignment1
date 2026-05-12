using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class InspectSystem : MonoBehaviour
{
    public Transform objectToInspect;

    public float rotationSpeed = 100f;

    private Vector3 previousMousePosition;

    public void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            previousMousePosition = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 deltaMousePosition = Input.mousePosition - previousMousePosition;
            float rotationX = deltaMousePosition.y * rotationSpeed * Time.deltaTime;
            float rotationY = deltaMousePosition.x * rotationSpeed * Time.deltaTime;

            Quaternion rotation = Quaternion.Euler(rotationX, -rotationY, 0);
            objectToInspect.rotation = rotation * objectToInspect.rotation;

            previousMousePosition = Input.mousePosition;
        }

        //BubbleRect.anchoredPosition = Cam.WorldToScreenPoint(ButtonPos.position);
    }

    public void Freeze()
    {
        rotationSpeed = 0;
    }

    public void UnFreeze()
    {
        rotationSpeed = 100;
    }


}
