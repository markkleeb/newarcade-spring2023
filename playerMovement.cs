using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode jump;
    public float speed = 10.0f;
    public float jumpForce = 10.0f;

    public Sprite jumpSprite;
    public Sprite idleSprite;

    private bool facingRight = true;
    private SpriteRenderer crocSR;
    private Rigidbody2D crocRB;

    // Start is called before the first frame update
    void Start()
    {
        crocSR = gameObject.GetComponent<SpriteRenderer>();
        crocRB = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(moveLeft)) {
        if(Input.GetAxisRaw("Horizontal") < 0) { 
            transform.Translate(Vector3.left * speed*Time.deltaTime);
            facingRight = false;
        }

        //if (Input.GetKeyDown(moveRight))
        if(Input.GetAxisRaw("Horizontal") > 0){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            facingRight = true;
        }

        if (Input.GetKeyDown(jump))
        {
            crocRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (crocRB.velocity.y < 0.5) {
            crocSR.sprite = idleSprite;
        }
        else
        {
            crocSR.sprite = jumpSprite;
        }



        if (facingRight)
        {
            crocSR.flipX = false;
        }
        else
        {
            crocSR.flipX = true;
        }





    }
}
