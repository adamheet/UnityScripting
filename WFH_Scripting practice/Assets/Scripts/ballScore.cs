using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScore : MonoBehaviour
{
    int ballscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision score)
    {
        Debug.Log("Contact was made");
       
    }
*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You Scored");
        ballscore += 1;
        if (ballscore == 10)
        {
            Debug.Log("You Win!!");
        }

    }
}
