using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGO;
    public GameObject fadeIn;
    public AudioSource BeepFx;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

   IEnumerator CountSequence()
   {
    yield return new WaitForSeconds(1.5f);
    countDown3.SetActive(true);
    BeepFx.Play();
    yield return new WaitForSeconds(1f);
    countDown2.SetActive(true);
    yield return new WaitForSeconds(1f);
    countDown1.SetActive(true);
    yield return new WaitForSeconds(1f);
    countDownGO.SetActive(true);
    PlayerMovement.canMove = true;
   }
}
