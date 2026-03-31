using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ReturnButton : MonoBehaviour
{
    public GameObject[] Bubble;
    public GameObject Canvas;
    public GameObject Background;
    public GameObject Penguin;
    public GameObject PenguinInspect;

    public void Return()
    {
        Canvas.SetActive(false);
        Background.SetActive(true);

        Penguin.SetActive(true);
        PenguinInspect.SetActive(false);

        foreach(GameObject gameObject in Bubble)
        {
            gameObject.SetActive(false);
        }

        PenguinInspect.transform.rotation = Quaternion.Euler(0f, -83.698f, 0f);
    }
}
