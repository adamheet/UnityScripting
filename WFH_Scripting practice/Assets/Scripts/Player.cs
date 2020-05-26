using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Score CurrentCount = new Score();
            //this creates a new instance of the "Score" class and sets its name to "CurrentCount"
        CurrentCount.Point = 8;
        //this sets the point value of the private "point" variable in the Score class to 10
        //print(CurrentCount.Point);
        //this prints out the value associated with the private "point" variable in the Score class
        CurrentCount.Point = 15;

        CurrentCount.Lives = 10;
        Debug.Log("lives "+ CurrentCount.Lives);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
