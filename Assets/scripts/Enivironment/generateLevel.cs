using UnityEngine;
using System.Collections;

public class generateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 53;
    public bool creatingSection = false;
    public int secNum;
    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0,3);
        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos+=99;
        yield return new WaitForSeconds(2);
        creatingSection = false;

    }
}
