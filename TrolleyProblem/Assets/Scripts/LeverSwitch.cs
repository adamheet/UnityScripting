using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSwitch : MonoBehaviour
{
    Vector3 state1;
    Vector3 state2;
    private bool standard;

    public float minAngle;
    public float maxAngle;

    // Start is called before the first frame update
    void Start()
    {
        standard = true;
        state1 = new Vector3(0f, minAngle, 0f);
        state2 = new Vector3(0f, maxAngle, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            if (standard)
            {
                gameObject.transform.Rotate(state2);
                standard = false;
                Debug.Log("changed to state2");
            }
            /*else if (standard == false)
            {
                gameObject.transform.Rotate(state1);
                standard = true;
                Debug.Log("changed to state1");
            }*/
        }
    }
}
