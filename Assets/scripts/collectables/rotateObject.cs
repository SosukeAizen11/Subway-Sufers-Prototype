using UnityEngine;

public class rotateObject : MonoBehaviour
{
    public int rotateSpeed = 1;

    void Update()
    {
        transform.Rotate(0,rotateSpeed , 0, Space.World);
    }
}
