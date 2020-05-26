using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics_testing : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float power;
    bool shooting = false;

    // Update is called once per frame


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shooting = true;
        }
    }

    void fixedupdate()
        {
        if (shooting)
        {
            Shoot();
            shooting = false;
        }
    
        }



    void Shoot()
    {
            Debug.Log("trigger worked");
            rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, power);
            
        
    }
}
