using Unity.VisualScripting;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject Antarctica;
    public GameObject AntarcticSea;
    public GameObject ArcticSea; 
    public GameObject Arctic;

    TitleManager titleManager;

    //ANTARCTICA
    public void AntarcticaLeftButton()
    {
        Antarctica.SetActive(false);
        AntarcticSea.SetActive(true);
        TitleManager.RoomNumber = 2;
        Debug.Log("2");
    }

    //ANTARCTICA SEA
    public void AntarcticSeaRightButton()
    {
        Antarctica.SetActive(true);
        AntarcticSea.SetActive(false);
        TitleManager.RoomNumber = 1;
        Debug.Log("1");
    }

    public void AntarcticSeaLeftButton()
    {
        AntarcticSea.SetActive(false);
        ArcticSea.SetActive(true);
        TitleManager.RoomNumber = 3;
        Debug.Log("3");
    }

    //ARCTIC SEA

    public void ArcticSeaRightButton()
    {
        AntarcticSea.SetActive(true);
        ArcticSea.SetActive(false);
        TitleManager.RoomNumber = 2;
        Debug.Log("2");
    }

    public void ArcticSeaLeftButton()
    {
        ArcticSea.SetActive(false);
        Arctic.SetActive(true);
        TitleManager.RoomNumber = 4;
        Debug.Log("4");
    }

    //ARCTIC
    public void ArcticRightButton()
    {
        ArcticSea.SetActive(true);
        Arctic.SetActive(false);
        TitleManager.RoomNumber = 3;
        Debug.Log("3");
    }
}



