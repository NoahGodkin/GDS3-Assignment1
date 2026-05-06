using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButton : MonoBehaviour
{
    [SerializeField] public GameObject info;

     public void Press()
    {
        info.SetActive(true);
    }

}
