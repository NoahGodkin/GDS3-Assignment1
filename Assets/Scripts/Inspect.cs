using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Inspect : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject Background;
    public GameObject AnimalInspect;

    public Transform AnimalInspectTransform;

    public GameObject OtherAnimal;

    public GameObject RoomChangeCanvas;

    public GameObject ScanningText;

    public Animator shutterAnim;
    public GameObject CameraShutter;

    public GameObject animalInspectRoom;
    public GameObject sceneRoom;

    private Vector3 currentAnimalPosition;

    InspectSystem InspectSystem;

    public void Start()
    {
        currentAnimalPosition = AnimalInspect.transform.position;
    }

    public void OnMouseDown()
    {
        InspectSystem.objectToInspect = AnimalInspectTransform;

        shutterAnimP();

        StartCoroutine(RoomChange());

        Invoke("scanningTextAppear", 0.5f);
    }

    public IEnumerator RoomChange()
    {
        AnimalInspect.transform.position = currentAnimalPosition;

        yield return new WaitForSeconds(1f);

        animalInspectRoom.SetActive(true);
        sceneRoom.SetActive(false);

        //Canvas.SetActive(true);
        //Background.SetActive(false);
        AnimalInspect.SetActive(true);

        OtherAnimal.SetActive(false);

        ReturnButton.currentAnimal = AnimalInspect;

        this.gameObject.SetActive(false); 

        ReturnButton.currentRoomChangeCanvas = RoomChangeCanvas;
        
        RoomChangeCanvas.SetActive(false);
    }

    public void scanningTextAppear()
    {
        ScanningText.SetActive(true);
        Invoke("scanningTextDisappear", 3.25f);
    }

    public void scanningTextDisappear()
    {
        ScanningText.SetActive(false);
    }

    public void shutterAnimP()
    {
        shutterAnim.SetTrigger("click");
    }
}
