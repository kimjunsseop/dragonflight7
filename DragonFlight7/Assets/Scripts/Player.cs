using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpeed {get;set;}
    // public GameObject Bullet;
    // public GameObject Launcher;
    
    void Start()
    {
        moveSpeed = 3f;
        // 싱글톤 연습
        //SingletonTest.instance.PlayerSound();
    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        // 범위로 충돌 한정
        // if(transform.position.x >= -2.1 && transform.position.x <= 2.1)
        // {
        //     transform.Translate(new Vector3(h,0,0) * moveSpeed * Time.deltaTime);   
        // }
        // else
        // {
        //     if(transform.position.x < -2)
        //     {
        //         transform.position = new Vector3(-2,transform.position.y,0);
        //     }
        //     else
        //     {
        //         transform.position = new Vector3(2,transform.position.y,0);
        //     }
        // }
        transform.Translate(new Vector3(h,0,0) * moveSpeed * Time.deltaTime);
    }


    // Player에는 isTrigger 체크가 안되어있어도
    // isTrigger 체크가 된 Object가 부딛힌다면
    // OnTriggerEnter2D 동작함.
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    // 만약 둘 다 isTrigger가 체크되어있지 않다면,
    // OnCollisionEnter2D가 동작.

    // 위 두개 다 둘 중 하나는 Rigidbody 2D가 있어야함.
}
