using Unity.VisualScripting;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject Antarctica;
    public GameObject AntarcticSea;
    public GameObject ArcticSea; 
    public GameObject Arctic;

    //ANTARCTICA
    public void AntarcticaLeftButton()
    {
        Antarctica.SetActive(false);
        AntarcticSea.SetActive(true);
    }

    //ANTARCTICA SEA
    public void AntarcticSeaRightButton()
    {
        Antarctica.SetActive(true);
        AntarcticSea.SetActive(false);
    }

    public void AntarcticSeaLeftButton()
    {
        AntarcticSea.SetActive(false);
        ArcticSea.SetActive(true);
    }

    //ARCTIC SEA

    public void ArcticSeaRightButton()
    {
        AntarcticSea.SetActive(true);
        ArcticSea.SetActive(false);
    }

    public void ArcticSeaLeftButton()
    {
        ArcticSea.SetActive(false);
        Arctic.SetActive(true);
    }

    //ARCTIC
    public void ArcticRightButton()
    {
        ArcticSea.SetActive(true);
        Arctic.SetActive(false);
    }
}



