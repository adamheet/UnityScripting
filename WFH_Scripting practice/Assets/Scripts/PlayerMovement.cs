using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    float xAxis;
    float zAxis;
    public float speed;
    Rigidbody rb;
    public float shootPower;
    public GameObject projectile;
    public Transform projectilepos;
    int availableshots = 10;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        xAxis = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector3(xAxis, rb.velocity.y, rb.velocity.z);

        if (Input.GetMouseButtonDown(0) && availableshots >0)
        {
            shoot();
            availableshots -= 1;
        }
    }

    void shoot()
    {
        GameObject shot = Instantiate(projectile, projectilepos.position,Quaternion.identity);
        shot.GetComponent<Rigidbody>().velocity= new Vector3(0f, 0f, shootPower);
        
    }
}
