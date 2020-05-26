using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStart : MonoBehaviour
{
    public Animator anim;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isChoosing", false);
     
    }

    // Update is called once per frame
    void Update()
    {
      
          if (Input.GetKeyDown("right"))
        {
            anim.SetBool("isChoosing", true);
            Debug.Log(anim.GetBool("isChoosing"));
        }



    }
}
