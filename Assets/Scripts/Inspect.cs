using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspect : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject Background;
    public GameObject AnimalInspect;

    public GameObject OtherAnimal;

    public GameObject RoomChangeCanvas;

    private void OnMouseDown()
    {
        Canvas.SetActive(true);
        Background.SetActive(false);
        AnimalInspect.SetActive(true);

        OtherAnimal.SetActive(false);

        ReturnButton.currentAnimal = AnimalInspect;

        this.gameObject.SetActive(false); 

        ReturnButton.currentRoomChangeCanvas = RoomChangeCanvas;
        
        RoomChangeCanvas.SetActive(false);
    }
}
