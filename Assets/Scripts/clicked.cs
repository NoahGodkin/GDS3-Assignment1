using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class clicked : MonoBehaviour
{
    private int clickCount = 0;

    public float maxDiffX = 0.15f;
    public float maxDiffZ = 0.02f;

    public GameObject info;
    public GameObject animal;

    private Camera mainCamera;
    private BoxCollider boxCollider;

    void Start()
    {
        info.SetActive(false);
        mainCamera = Camera.main;
        boxCollider = GetComponent<BoxCollider>();
    }

    public void OnMouseDown()
    {
        clickCount++;
        info.SetActive(true); 

        if (clickCount > 1)
        {
            info.SetActive(false);
            clickCount = 0;
        }
    }

    void Update()
    {
        if (info.activeSelf == false)
        {
            return; // won't proceed from here
        }



        // Sphere cast from the button towards the camera
        // If the animal blocks the raycast, hide it

        
        Vector3 castDirection = -mainCamera.transform.forward;
        Vector3 boxExtents = new Vector3(boxCollider.size.x/2f, boxCollider.size.y/2f, 0.001f);
        RaycastHit[] hits = Physics.BoxCastAll(transform.position, boxExtents, castDirection);

        if (hits.Length > 0)
        {
            bool foundAnimal = false;
            RaycastHit animalHit = new RaycastHit();
            foreach (RaycastHit hit in hits)
            {
                if (hit.transform == animal.transform)
                {
                    foundAnimal = true;
                    animalHit = hit;
                }
                    
                break;
            }

            if (foundAnimal)
            {
                Bounds b1 = new Bounds(
                    new Vector3(transform.position.x, transform.position.y, 0), 
                    new Vector3(boxCollider.size.x, boxCollider.size.y, 0));
                Bounds b2 = new Bounds(
                    new Vector3(animalHit.transform.position.x, animalHit.transform.position.y, 0), 
                    new Vector3(animalHit.collider.bounds.size.x, animalHit.collider.bounds.size.y, 0));

                if (b1.min.x <= b2.min.x && b1.max.x >= b2.max.x && b1.min.y <= b2.min.y && b1.max.y >= b2.max.y)
                {
                    print("Yep");
                    if (animalHit.transform.position.z - transform.position.z > 0)
                        info.SetActive(false);
                }
            }          

            //print($"xMin: {b1.min.x >= b2.min.x}, xMax:{b1.max.x <= b2.max.x}, yMin: {b1.min.y >= b2.min.y}, yMax:{b1.max.y <= b2.max.y}");

           
         
            

            
        }

        
    }

}
