using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class takeDamage : MonoBehaviour
{
    public int hitpoints;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(hitpoints);
    }

    // Update is called once per frame
    void Update()
    {
        if(1<hitpoints && hitpoints<5)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (hitpoints == 1)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (hitpoints == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("DeathScreen");
        }
    }

    private void OnCollisionEnter(Collision contact)
    {
        if (contact.gameObject.tag == "weapon")
        {
            hitpoints -= 1;
            Debug.Log(hitpoints);
            Destroy(contact.gameObject);
           }
        if (contact.gameObject.tag == "coin")
        {
            score += 1;
            Debug.Log(score);            
            Destroy(contact.gameObject);
        }
    }

   

}
