using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    public Transform Ltarget;
    public Transform Rtarget;
    public float speed;

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Ltarget.position, speed * Time.deltaTime);

        if (transform.position == Ltarget.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, Rtarget.position, speed * Time.deltaTime);
        }

        if (transform.position == Rtarget.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, Ltarget.position, speed * Time.deltaTime);
        }
    }
}
