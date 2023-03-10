using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{
    //variable for the ball we're locking the camera onto
    public Transform ball;
    //variable for the offest between the ball and the camera position
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //calculating offset by the difference between the ball's position and the camera position
        offset = transform.position - ball.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //changing the position of the camera by adding the position of the ball + the offset we just calculated
        transform.position = ball.transform.position + offset;
    }
}
