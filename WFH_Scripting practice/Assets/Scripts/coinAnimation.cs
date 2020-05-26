using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float score = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, speed);
    }
}
