using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderScript : MonoBehaviour
{
    public static float speed = 20.0f;

    private GCScript gcscript;

    void Awake()
    {
        gcscript = GameObject.Find("GameController").GetComponent<GCScript>();
    }

    void Start()

    {
    }


    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //check to see if we collide with the wall
        if (collision.gameObject.tag == "Wall")
        {
            speed = speed*-1; //reverse speed

            //move all invaders down at once:
            GameObject[] invaders = GameObject.FindGameObjectsWithTag("Invader");

            foreach (GameObject i in invaders)
            {
                i.transform.Translate(Vector2.down * 10 * Time.deltaTime);
            }
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            gcscript.killed();
        }
       


    }

}
