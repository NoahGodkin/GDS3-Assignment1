using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimalMoveInspect : MonoBehaviour
{

    public float speed = 1;
    public Vector3 target = new Vector3(0, 0, 2);

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime); 
    }
}
