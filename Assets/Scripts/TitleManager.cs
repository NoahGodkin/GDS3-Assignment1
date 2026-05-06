using UnityEngine;
using TMPro;

public class TitleManager : MonoBehaviour
{
    public TextMeshProUGUI Title;

    public static int RoomNumber;

    public void Start()
    {
        Title.text = "antarctica";
    }

    private void Update()
    {
        if (RoomNumber == 1)
        {
            Title.text = "antarctica";
        }

        if (RoomNumber == 2)
        {
            Title.text = "antarctic sea";
        }

        if (RoomNumber == 3)
        {
            Title.text = "arctic sea";
        }

        if (RoomNumber == 4)
        {
            Title.text = "arctic";
        }
    }
}
