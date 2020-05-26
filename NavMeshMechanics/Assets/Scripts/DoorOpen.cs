using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (open)
            {
                transform.Translate(-3, 0, -5);
                open = false;
            }
            else
            {
                transform.Translate(3, 0, 5);
                open = true;
            }
        }
    }
}
