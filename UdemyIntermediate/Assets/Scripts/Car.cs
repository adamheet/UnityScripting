using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Car 
{
    //attributes are variables
    public float speed;
    public int topspeed;
    public string color;
    public float gears;

    public Car()
    {
        Debug.Log("Car() constructor called");
    }

    public Car(float speed,int topspeed,string color)
    {
        this.speed = speed;
        this.topspeed = topspeed;
        this.color = color;
        Debug.Log("Car(speed,int,string) constructor called");
    }



    //behaviors are methods
    void move()
    {
        Debug.Log("moving");
    }

    void brake()
    {
        Debug.Log("braking");
    }

    public void printspeed()
    {
        Debug.Log(speed);
    }

    public void printDetails()
    {
        Debug.Log("speed is = " + speed);
        Debug.Log("topspeed is = " + topspeed);
        Debug.Log("color is  = " + color);
        Debug.Log("gears is = " + gears);
    }
}
