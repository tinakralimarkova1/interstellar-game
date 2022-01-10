using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclespawn : MonoBehaviour
{

    public GameObject obstacle;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBspawn;
    private float spawnTime;


    

    // Update is called once per frame
    void Update()
    {
       // if (Time.time > spawnTime)
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
