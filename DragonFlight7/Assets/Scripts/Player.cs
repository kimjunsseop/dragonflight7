using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        if(transform.position.x >= -2.1 && transform.position.x <= 2.1)
        {
            transform.Translate(new Vector3(h,0,0) * moveSpeed * Time.deltaTime);   
        }
        else
        {
            if(transform.position.x < -2)
            {
                transform.position = new Vector3(-2,transform.position.y,0);
            }
            else
            {
                transform.position = new Vector3(2,transform.position.y,0);
            }
        }    
    }
}
