using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour

{

    public float trainspeed;
    float zmove;
    Rigidbody Movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zmove = Input.GetAxis("Vertical") * trainspeed;
        Movement = GetComponent<Rigidbody>();
        Movement.velocity = new Vector3(0, 0, zmove);
        //walker.velocity = new Vector3(xMove, walker.velocity.y, zMove);
    }
}
