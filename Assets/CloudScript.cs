using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float MoveSpeed;
    private float deadzone = -31;
    void Start()
    {
      
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("Cloud deleted");
            Destroy(gameObject);
        }
    }
   
}
