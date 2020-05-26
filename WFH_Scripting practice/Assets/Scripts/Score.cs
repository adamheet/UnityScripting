using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score 
{

    private int point;
    private int lives;

    //here we're using a public variable "Point" to modify and apply values to a private variable "point"
    //think of "Point" as being a public gateway into a private variable
    //We're denoting the public one through the capitalization

    public int Point
    {
        get
        {
            return point;
            //this pulls in the value of the private variable
        }

        set
        {
            //point = value;
            //this assigns the value to whatever is being given to the public 

            //we can add conditions to this transformation that only happen when they are met
            //for example
            if(value >5 && value < 10)
            {
                point = value;
            }
            PrintPoint();
        }

    }

    public int Lives { get; set; }

    void PrintPoint()
    {
        Debug.Log(point);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
