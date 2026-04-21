using UnityEngine;

public class ModelReset : MonoBehaviour
{
    public void OnMouseDown()
    {
        ReturnButton.currentAnimal.transform.rotation = Quaternion.Euler(0f, -83.698f, 0f);
    }
}
