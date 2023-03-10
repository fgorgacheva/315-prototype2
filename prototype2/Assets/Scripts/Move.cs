using UnityEngine;

public class Move : MonoBehaviour
{

    //set default ball speed to 0.1
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        //get XZ soordinate positions
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        //create a vector in which you pass the coordinates and default the Y coordinates 
        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        //setting the speed by multiplying the speed we chose by its direction of povement and adding it to its position (this refreshes every frame)
        transform.position += moveDirection * speed;

    }
}
