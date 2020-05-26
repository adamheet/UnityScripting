using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public float charge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Renderer>().material.color = Color.red;
        other.GetComponent<Rigidbody>().velocity = new Vector3(0f, charge, 0f);
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Renderer>().material.color = Color.white;
        // other.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        Destroy(gameObject);
    }
}

