using UnityEngine;

public class ModelReset : MonoBehaviour
{
    Inspect AnimalRotation;

    public void OnMouseDown()
    {
        ReturnButton.currentAnimal.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
