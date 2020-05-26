using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
     public float speed;
    
   

    void Update()
    {
     
        float zInput = Input.GetAxis("Vertical") * speed *  Time.deltaTime;
        float xInput = Input.GetAxis("Horizontal") * speed *  Time.deltaTime;
        transform.Translate(xInput,0,0);
        transform.Translate(0, 0, zInput);

       
       
    }

          
    
}
