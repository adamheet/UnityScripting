using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCar : MonoBehaviour
{
    public GameObject vehicle;
    public Transform origin;
    public string direction;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(direction))
        {
            Instantiate(vehicle, origin);
        }
    }
}
