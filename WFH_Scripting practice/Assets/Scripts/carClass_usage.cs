using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class carClass_usage : MonoBehaviour
{
    // Start is called before the first frame update

    public Car PublicCar;

    void Start()
    {

        PublicCar.PrintDetails();
        
        //Car myCar = new Car();
        //this line creates an instance of the "Car" class that we made using the default constructor
        //just like "string name" would create a new instance of a string variable

        // myCar.speed = 10.5f;
        //myCar.color = "red";
        // myCar.highestSpeed = 20;

        // Car suzuki = new Car();

        // suzuki.speed = 20f;
        //suzuki.color = "black";
        // suzuki.highestSpeed = 200;

        //suzuki.CarSpeed();
        // myCar.CarSpeed();

        //Car ford = new Car(20f, "black");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
