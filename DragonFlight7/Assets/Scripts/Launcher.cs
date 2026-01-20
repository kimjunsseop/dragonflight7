using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 1.5f);
    }
    void Shoot()
    {
        if(bullet != null)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            SoundManager.instance.SoundExplosion();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
