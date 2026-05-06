using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Image Image;
    public Sprite Squish;
    public Sprite Normal;

    public void OnEnable()
    {
        Image.sprite = Normal;
        StartCoroutine(ImageChanger());
    }

    public IEnumerator ImageChanger()
    {
        while (true)
        {
            if (Image.sprite = Normal)
            {
                yield return new WaitForSeconds(1f);

                Image.sprite = Squish;
            }

            if (Image.sprite = Squish)
            {
                yield return new WaitForSeconds(1f);

                Image.sprite = Normal;
            }
        }
    }
}
