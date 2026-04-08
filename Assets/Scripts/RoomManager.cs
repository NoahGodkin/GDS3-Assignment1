using Unity.VisualScripting;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject Room1;
    public GameObject Room2;
    public GameObject Room3;

    //ROOM 1 BUTTONS
    public void R1RightButton()
    {
        Room1.SetActive(false);
        Room2.SetActive(true);
        Room3.SetActive(false);
    }

    //ROOM 2 BUTTONS
    public void R2RightButton()
    {
        Room1.SetActive(false);
        Room2.SetActive(false);
        Room3.SetActive(true);
    }

    public void R2LeftButton()
    {
        Room1.SetActive(true);
        Room2.SetActive(false);
        Room3.SetActive(false);
    }

    //ROOM 3 BUTTONS
    public void R3LeftButton()
    {
        Room1.SetActive(false);
        Room2.SetActive(true);
        Room3.SetActive(false);
    }
}



