using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicked : MonoBehaviour
{
    private int clickCount = 0;

    public GameObject info;

    void Start()
    {
        info.SetActive(false);
    }

    public void OnMouseDown()
    {
        clickCount++;
        info.SetActive(true); 

        if (clickCount > 1)
        {
            info.SetActive(false);
            clickCount = 0;
        }
    }

    void Update()
    {
        if (info.activeSelf == false)
        {
            return; // won't proceed from here
        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            info.SetActive(false);
        }
    }
}
