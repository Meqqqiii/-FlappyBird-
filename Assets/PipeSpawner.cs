using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate;
    private float timer;
    public float hightofset = 5;
    
    void Start()
    {
        Spawnpipe();
    }
    void Update()
    {
        if (timer <spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Spawnpipe();
        }
        
    }
    void Spawnpipe()
    {
        float lowestpoint = transform.position.y - hightofset;
        float highsetpoint = transform.position.y + hightofset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highsetpoint),0), transform.rotation);
        timer = 0;
    }
} 
