using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    float xMove;
    float yMove;
    float zMove;
    public float walking;
    Rigidbody walker;
    bool jump = false;
    private float run = 1f;
    public float boost;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left shift"))
        {
            Debug.Log("Left shift held down");
            run = 3;
        }
        else
        {
            run = 1;
        }
        

       xMove = Input.GetAxis("Horizontal") * walking * run;
       zMove = Input.GetAxis("Vertical") * walking * run;
       
       

        if (Input.GetButtonDown("Jump") && GetComponent<Rigidbody>().velocity.y==0)
        {
            jump=true;
        }
    }

    private void FixedUpdate()
    {
        walker = GetComponent<Rigidbody>();
        walker.velocity = new Vector3(xMove, walker.velocity.y, zMove);
        if (jump)
        {
            Jumping();
        }
    }

    void Jumping()
    {
        //walker.AddForce(0f, boost, 0f);
        walker.velocity = new Vector3(0f, boost, 0f);
        jump = false;
    }

    

    }
