using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript Logic;
    public BirdScript Bird1;
    

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Bird1 = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && Bird1.birdIsAlive)
        {
            Logic.addscore(1);
        
        }
       
    }
}
