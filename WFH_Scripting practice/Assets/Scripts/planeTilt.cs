using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeTilt : MonoBehaviour
{
    float zrotate;
    //side to side
    float xrotate;
    //front to back
    public float rotatespeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xrotate = Input.GetAxis("Mouse Y") * rotatespeed;
        zrotate = Input.GetAxis("Mouse X") * rotatespeed;

        transform.Rotate(xrotate, 0f, zrotate);
    }
}
