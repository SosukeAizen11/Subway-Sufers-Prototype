using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class endRunSequence : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject FadeOut;
    void Start()
    {
        StartCoroutine(EndSequence());
    }
    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);

    }
   
}
