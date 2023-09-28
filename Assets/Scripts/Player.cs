using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    private Vector3 spawnPoint;

    
    

    

    

    void Start()
    {
        spawnPoint = transform.position;
        
    }

    
        

    private void Update()
    {
        Vector3 moveDirection = new Vector3();
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");

        

        transform.position += moveDirection * speed * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = moveDirection * speed;
        transform.forward = moveDirection;
        


        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.name);

        if (collision.gameObject.name == "enemy")
        {
            transform.position = spawnPoint;
            string name = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(name);
        }
    }
}

