using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float xAxis = 0.01f;
    public float yAxis = 0.01f;
    public float zAxis = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        this.GetComponent<Transform>().Rotate(xAxis, yAxis, zAxis);
    }
}
