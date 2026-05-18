using UnityEngine;
using TMPro;
using System.Collections;

public class TypewritterEffect : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textMeshPro;

    public string[] stringArray;

    [SerializeField] float timeBtwnChars; 

    int i = 0;


    public void EndCheck()
    {
        if (i <= stringArray.Length - 1)
        {
            _textMeshPro.text = stringArray[i];
            StartCoroutine(TextVisible());
        }
    }

    private void OnEnable()
    {
        i = 0;
        EndCheck();
    }


    public IEnumerator TextVisible()
    {
        _textMeshPro.ForceMeshUpdate();
        int totalVisibleCharacters = _textMeshPro.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);
            _textMeshPro.maxVisibleCharacters = visibleCount;

            if(visibleCount >= totalVisibleCharacters)
            {
                i += 1;
                Invoke("EndCheck", timeBtwnChars);
                break;
            }

            counter += 1;
            yield return new WaitForSeconds(timeBtwnChars);
        }
    }
}
