using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{

    TitleManager titleManager;

    //ANTARCTICA
    public void AntarcticaLeftButton()
    {
        SceneManager.LoadScene(2);
    }

    //ANTARCTICA SEA
    public void AntarcticSeaRightButton()
    {
        SceneManager.LoadScene(3);
    }

    public void AntarcticSeaLeftButton()
    {
        SceneManager.LoadScene(1);
    }

    //ARCTIC SEA

    public void ArcticSeaRightButton()
    {
        SceneManager.LoadScene(2);
    }

    public void ArcticSeaLeftButton()
    {
        SceneManager.LoadScene(0);
    }

    //ARCTIC
    public void ArcticRightButton()
    {
        SceneManager.LoadScene(1);
    }
}



