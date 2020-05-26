using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartThrow : MonoBehaviour
{
    public GameObject dart;
    public Transform source;
    public float dartSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider panel)
    {
        // dart.GetComponent<Rigidbody>().velocity = new Vector3(8f, 0f, 0f);
        // Instantiate(dart);
        GameObject shot = Instantiate(dart, source.position, Quaternion.identity);
        shot.GetComponent<Rigidbody>().velocity = new Vector3(dartSpeed, 0f, 0f);
        
    }
}
