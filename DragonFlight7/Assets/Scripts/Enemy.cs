using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float Speed {get;set;}
    Vector3 stratPosition;
    void Start()
    {
        Speed = 1.5f;
        stratPosition = transform.position;
        // 싱글톤 연습
        //SingletonTest.instance.EnemySound();
    }
    void Update()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
        //trasnform.Translate(0, -Speed * Time.deltaTime, 0);
        // 방식은 여러가지
        // float distY = Speed * Time.deltaTime;
        //trasnform.Translate(0, -distY, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);        
    }

    // Enemy에서 bullet을 이렇게 지워도 됨
    // void OnTriggerEnter2D(Collider2D collision)
    // {
    //     //collision.tag == "Bullet"
    //     //collision.gameObject.tag == "Bullet"
    //     if(collision.gameObject.CompareTag("Bullet")) // 이게 젤 안전
    //     {
    //         Destroy(gameObject);
    //         Destroy(collision.gameObject);
    //     }
    // }
}
