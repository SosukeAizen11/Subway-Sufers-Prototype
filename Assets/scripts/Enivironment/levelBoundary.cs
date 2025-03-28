using UnityEngine;

public class levelBoundary : MonoBehaviour
{
    public static float leftSide = -4f;
    public static float rightSide = 4f;
    public float internalLeft;
    public float internalRight;


    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;

    }
}
