using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource Collide;
    public GameObject mainCam;
    public GameObject levelControl;

     void OnTriggerEnter(Collider other)
     {
      this.gameObject.GetComponent<BoxCollider>().enabled = false;
      thePlayer.GetComponent<PlayerMovement>().enabled = false;
      charModel.GetComponent<Animator>().Play("Sweep Fall");
      levelControl.GetComponent<LevelDistance>().enabled = false;
      Collide.Play();
      mainCam.GetComponent<Animator>().enabled = true;
      levelControl.GetComponent<endRunSequence>().enabled = true;

     }
}
