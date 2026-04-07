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

    public GameObject PolarBear;
    public GameObject PolarBearInspect;

    public static GameObject currentAnimal;

    public GameObject RoomChangeCanvas;

    public void Return()
    {
        Canvas.SetActive(false);
        Background.SetActive(true);

        Penguin.SetActive(true);
        PolarBear.SetActive(true);
        currentAnimal.SetActive(false);

        RoomChangeCanvas.SetActive(true);

        foreach(GameObject gameObject in Bubble)
        {
            gameObject.SetActive(false);
        }

        PenguinInspect.transform.rotation = Quaternion.Euler(0f, -83.698f, 0f);

        PolarBearInspect.transform.rotation = Quaternion.Euler(0f, -83.698f, 0f);
    }
}
