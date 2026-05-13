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

    public GameObject OtherAnimal;

    public GameObject RoomChangeCanvas;

    public GameObject ScanningText;

    public Animator shutterAnim;
    public GameObject CameraShutter;

    public GameObject animalInspectRoom;
    public GameObject sceneRoom;

    //public void Start()
    //{
    //    ScanningText.SetActive(false);
    //}

    public void OnMouseDown()
    {
        shutterAnimP();

        StartCoroutine(RoomChange());

        Invoke("scanningTextAppear", 0.5f);
    }

    public IEnumerator RoomChange()
    {

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
        Invoke("scanningTextDisappear", 3f);
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
