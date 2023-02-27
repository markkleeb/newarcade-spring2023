using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{

    //ship speed
    public float speed = 10f;


    //horizontal variable to store our input values
    private float horizontal;

    //find the Bullet
    public GameObject bullet;

    private AudioSource laser;

    void Awake()
    {
        laser = GetComponent<AudioSource>();
    }

    void Start()
    {
        

    }


    void Update()
    {

        //Check for inputs, set equal to a vector
        horizontal = Input.GetAxisRaw("Horizontal");

        //move ship along the X axis according to speed
        transform.Translate(new Vector2(horizontal * speed * Time.deltaTime, 0));


        //If we press spacebar, initialize a bullet object
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 90));
            laser.Play();
        }

       
    }
}
