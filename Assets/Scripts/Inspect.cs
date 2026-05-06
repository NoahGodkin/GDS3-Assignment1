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

    //ShutterAnimPlay shutterAnimPlay;

    public Animator shutterAnim;

    public void OnMouseDown()
    {
        shutterAnimP();

        StartCoroutine(RoomChange());

    }

    public IEnumerator RoomChange()
    {

        yield return new WaitForSeconds(1f);

        Canvas.SetActive(true);
        Background.SetActive(false);
        AnimalInspect.SetActive(true);

        OtherAnimal.SetActive(false);

        ReturnButton.currentAnimal = AnimalInspect;

        this.gameObject.SetActive(false); 

        ReturnButton.currentRoomChangeCanvas = RoomChangeCanvas;
        
        RoomChangeCanvas.SetActive(false);
    }

    public void shutterAnimP()
    {
        shutterAnim.SetTrigger("click");
    }
}
