using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRAnge = 50;

    public GameObject projectilePrefab;
    void Start()
    {
        Debug.Log("Let's Start Feeding The Animals. Here We Go On This Adventure.");
        
    }

    
    void Update()
    {   
        //Keep the Player in bounds.
        if (transform.position.x<-xRAnge)
        {
            transform.position = new Vector3(-xRAnge, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRAnge)
        {
            transform.position = new Vector3(xRAnge, transform.position.y, transform.position.z);
        }
        //Moving the player.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime*speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        //Mermi ATmak için örnek kodlama
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from player 
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
