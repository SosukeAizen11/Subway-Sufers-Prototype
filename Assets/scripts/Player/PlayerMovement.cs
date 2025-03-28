using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float LeftRightSpeed = 4;



    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed , Space.World);
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) )
        {
            if(this.gameObject.transform.position.x > levelBoundary.leftSide)
            {
            transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed);
            }
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) )
        {
            if(this.gameObject.transform.position.x < levelBoundary.rightSide)
            {
            transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed * -1);
            }
        }
    }
}
