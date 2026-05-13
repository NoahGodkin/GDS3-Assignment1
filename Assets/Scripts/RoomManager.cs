using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{

    TitleManager titleManager;

    //ANTARCTICA
    public void ArcticLeftButton()
    {
        SceneManager.LoadScene(1);
    }

    //OCEAN

    public void OceanRightButton()
    {
        SceneManager.LoadScene(2);
    }

    public void OceanLeftButton()
    {
        SceneManager.LoadScene(0);
    }

    //ARCTIC
    public void AntarcticaRightButton()
    {
        SceneManager.LoadScene(1);
    }
}



