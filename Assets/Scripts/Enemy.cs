using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Plane")) return;
        

        
        speed = -speed;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if(rb != null)rb.velocity = speed;
    }
}   
