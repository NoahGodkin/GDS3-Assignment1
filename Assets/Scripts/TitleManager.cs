using UnityEngine;
using TMPro;
using Unity.VectorGraphics;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    //public string[] Titles;

    public TextMeshProUGUI Title;

    public static int RoomNumber;

    public void Start()
    {
        Title.text = "antarctica";
    }

    private void Update()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentIndex == 3)
        {
            Title.text = "antarctica";
        }

        if (currentIndex == 2)
        {
            Title.text = "antarctic sea";
        }

        if (currentIndex == 1)
        {
            Title.text = "arctic sea";
        }

        if (currentIndex == 0)
        {
            Title.text = "arctic";
        }
    }
}
