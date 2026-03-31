using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspect : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject Background;
    public GameObject AnimalInspect;

    private void OnMouseDown()
    {
        Canvas.SetActive(true);
        Background.SetActive(false);
        AnimalInspect.SetActive(true);
        
        this.gameObject.SetActive(false);  
    }
}
