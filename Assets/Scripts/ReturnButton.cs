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

    public static GameObject currentRoomChangeCanvas;

    public GameObject animalInspectRoom;
    public GameObject sceneRoom;

    public Camera mainCamera;

    public void Start()
    {
        mainCamera = Camera.main;
    }

    public void Return()
    {
        mainCamera.fieldOfView = 60;

        animalInspectRoom.SetActive(false);
        sceneRoom.SetActive(true);

        //Canvas.SetActive(false);
        //Background.SetActive(true);

        Penguin.SetActive(true);
        PolarBear.SetActive(true);
        currentAnimal.SetActive(false);

        currentRoomChangeCanvas.SetActive(true);

        foreach(GameObject gameObject in Bubble)
        {
            gameObject.SetActive(false);
        }

        PenguinInspect.transform.rotation = Quaternion.Euler(0f, -83.698f, 0f);

        PolarBearInspect.transform.rotation = Quaternion.Euler(0f, -83.698f, 0f);
    }
}
