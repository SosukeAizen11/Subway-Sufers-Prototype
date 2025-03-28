using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;

    // Update is called once per frame
    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
    }
}
