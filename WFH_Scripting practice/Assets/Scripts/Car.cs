using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
// because we've removed ": MonoBehaviour" after the name of the Class, we cannot attach this script to a game object
// we are only using this script to organize attributes and behaviors of other objects
// think of this as being a collection of things that we can access through other scripts

public class Car {

    //variables are our attributes (features)
    //these variables will apply to the default constructor
    public float speed;
    public string color;
    public int highestSpeed;

    //methods(functions) are our behaviors

    public Car(float speed, string color)
    {
        this.speed = speed;
        this.color = color;
        //"this.speed" refers to the speed variable within this class
        // the "=speed" tells it to assign whatever you are putting in the parenthasis within the other call script and assign it to this native variable
    }

    public Car()
    {
        Debug.Log("Car() called");
    }


    void move()
    {
        Debug.Log("Moving");
    }
        
    void applyBreak()
    {
        Debug.Log("Applying break");
    }

    public void CarSpeed()
    {
        Debug.Log(speed);
    }

    public void PrintDetails()
    {
        Debug.Log("speed =" + speed);
        Debug.Log("color = " + color);
        Debug.Log("highest speed =" + highestSpeed);
    }
}
