using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D BirdRigidbody;
    public float flapstrenght;
    public LogicScript Logic;
    public bool birdIsAlive = true;
    public AudioSource fail;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            BirdRigidbody.velocity = Vector2.up * flapstrenght;
        }
       if (transform.position.y >9 || transform.position.y <-8.7)
        {
            fail.Play();
            Logic.gameOver();
            birdIsAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            fail.Play();
            Logic.gameOver();
            birdIsAlive = false;
        }
    }

}
