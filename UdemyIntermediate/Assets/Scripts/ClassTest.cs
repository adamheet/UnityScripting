using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour
{
    // Start is called before the first frame update
    public Car Jeep;
    public Car Kia;

    void Start()
    {
        /* Car Honda = new Car();
         Honda.speed = 10.5f;
         Honda.topspeed = 30;
         Honda.color = "Red";

         Car Ford = new Car();
         Ford.speed = 5f;
         Ford.topspeed = 15;
         Ford.color = "Green";

         Ford.printspeed();
         Honda.printspeed();

         Car Kia = new Car(15.5f, 80, "Grey");
         */

        Jeep.printDetails();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
