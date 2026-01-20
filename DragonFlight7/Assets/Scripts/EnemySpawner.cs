using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float interval = 1.5f;
    private float time = 0;
    void Start()
    {
        //InvokeRepeating("Spawn", 0.5f, 1f);
        StartCoroutine(Spawner());
    }

    void Update()
    {
        // time += Time.deltaTime;
        // if(time > interval)
        // {
        //     int rd = UnityEngine.Random.Range(-2,3);
        //     Instantiate(enemy, new Vector3(rd,4.5f,0), Quaternion.identity);
        //     time = 0;
        // }
    }

    IEnumerator Spawner()
    {
        while(true)
        {
            if(enemy != null)
            {
                int rd = UnityEngine.Random.Range(-2,3);
                Instantiate(enemy, new Vector3(rd,4.5f,0), Quaternion.identity);
                yield return new WaitForSeconds(interval);
            }
        }
    }

    
    private void Spawn()
    {
        int rand = UnityEngine.Random.Range(-2,3);
        if(enemy != null)
        {
            Instantiate(enemy, new Vector3(rand, 4.5f, 0), Quaternion.identity);
        }
    }
}
