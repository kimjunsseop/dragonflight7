using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float BulletSpeed {get;set;}
    public GameObject effect;
    void Start()
    {
        BulletSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * BulletSpeed * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);        
    }

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.gameOjbect.tag
        //collision.gameObject.CompareTag("Enemy"); 이게 젤 안전
        if(collision.tag == "Enemy")
        {
            if(effect != null)
            {
                GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
                Destroy(go, 1);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SoundManager.instance.SoundDie();
            GameManager.instance.AddScore(100);
        }
    }
}
