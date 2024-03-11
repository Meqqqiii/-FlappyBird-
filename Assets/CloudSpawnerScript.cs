using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject Cloud;
    public float spawnrate;
    private float timer;
    public float hightofset = 5;
    void Start()
    {
        SpawnCloud();
    }
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnCloud();
        }
    }
    void SpawnCloud()
    {
        float lowestpoint = transform.position.y - hightofset;
        float highestpoint = transform.position.y + hightofset;
        Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
        timer = 0;
    }
}
