using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float speedIncreaseRate = 0.1f; // Rate at which speed increases
    public float speedIncreaseInterval = 5f; // Time in seconds between speed increases
    private float nextSpeedIncreaseTime = 0f;

    public float LeftRightSpeed = 4;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;

    void Update()
    {
        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        // Gradually increase moveSpeed
        if (Time.time >= nextSpeedIncreaseTime)
        {
            moveSpeed += speedIncreaseRate;
            nextSpeedIncreaseTime = Time.time + speedIncreaseInterval;
        }

        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > levelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed);
                }
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < levelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed * -1);
                }
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Running Forward Flip");
                    StartCoroutine(JumpSequence());
                }
            }
        }

        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            else
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.5f);
        comingDown = true;
        yield return new WaitForSeconds(0.5f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Running");
    }
}
