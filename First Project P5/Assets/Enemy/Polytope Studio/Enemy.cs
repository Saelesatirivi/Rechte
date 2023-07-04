using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     Rigidbody rb;
     public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x + 0.03f, rb.velocity.y , rb.velocity.z) * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x - 0.03f, rb.velocity.y , rb.velocity.z) * speed;
        }
    }
}